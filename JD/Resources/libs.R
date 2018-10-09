#force to use the library from R-portable
temp.libPaths <- .libPaths()
if(length(temp.libPaths) > 1){
	.libPaths(new = temp.libPaths[2])
}

library(odbc)
library(RSQLite)
library(sqldf)

# return a list of a child using code 
# this list is used for plotting.
dataID <- function(code,con=db){
	#get child i data
	statement <- paste0('SELECT * FROM jdb WHERE Code == ',code)
	dat <- RSQLite::dbGetQuery(con, statement)
  
	# all the row numbers for child i
	ic<-dat
	# all the ages for child i
	age <- as.numeric(dat[,2])
	# all the sbr values for child i
	sbr <- as.numeric(dat[,4])
	# EGA for child i
	ega <- round(min(as.numeric(dat[,14])))
	# EGA specific threshold for child i
	  ap<-c(0,3)*24
	  yp<-c(40,(130+(ega-23)*10))
	  ae<-c(0,3)*24
	  ye<-c(80,(230+(ega-23)*10))
	  for (w in 1:3){
			ap<-c(ap,2*w*24*7,2*w*24*7)
			yp<-c(yp,(130+(ega+2*(w-1)-23)*10),(130+(ega+2*w-23)*10))
			ae<-c(ae,2*w*24*7,2*w*24*7)
			ye<-c(ye,(230+(ega+2*(w-1)-23)*10),(230+(ega+2*w-23)*10))
	  }
	  yp<-yp+(350-yp)*(yp>270)
	  yp50<-yp-50
	  ye<-ye+(450-ye)*(ye>370)
	  ye50<-ye-50
  
	  # get number of photo type events
	  npt <- sum(na.omit(as.numeric(dat[,27])))
	  bpt<-rep(0,npt)
	  ept<-rep(0,npt)
	  tpt<-rep(0,npt)
	  # begin photo j for child i
	  #bpt<-as.numeric(na.omit(age[JDF[ic,27]==1  ]))
	  bpt <- as.numeric(na.omit(age[as.numeric(dat[,27])==1]))
	  # end photo j for child i
	  #ept<-as.numeric(na.omit(age[JDF[ic,28]==1]))
	  ept <- as.numeric(na.omit(age[as.numeric(dat[,28])==1]))
	  # phototherapy type
	  #tpt<-as.numeric(na.omit(JDF[ic,26]*(JDF[ic,27]==1)))
	  tpt <- as.numeric(na.omit(as.numeric(dat[,26])*(as.numeric(dat[,27])==1)))
  
	  out <- list(ic=ic,age=age,sbr=sbr,ega=ega,ap=ap,yp=yp,ae=ae,ye=ye,yp50=yp50,ye50=ye50,npt=npt,bpt=bpt,ept=ept,tpt=tpt)
  
  return(out)
}

IDMemberQ <- function(id, con=db){
  #checking the id from jdb table
  dat <- RSQLite::dbGetQuery(con, 'SELECT Code FROM jdb')
  ids <- unique(dat[,])
  return(as.numeric(is.element(id,ids))) #return 1 if T 0 if F
}



PlotData <- function(code,con=db){
  
  data <- dataID(code,con)
  
  # get limits for plot
  #maxage<-max(JDF[,2])
  #maxsbr<-max(na.omit(JDF[,4]))
  maxage <- 650
  maxsbr <- 550

  wd<-2 # set line width for plots
  
  plot(data$age,data$sbr,type="l",
       xlim=c(0,maxage),ylim=c(0,maxsbr),
       xlab='Age (hours)', ylab='Bilirubin level (umol/l)',
       lwd=1,
       main=paste("Child ID number = ",code,", EGA = ",data$ega))
  
  # get number of photo events
  np<-max(na.omit(as.numeric(data$ic[,10])))
  bp<-rep(0,np)
  ep<-rep(0,np)
  for(j in 1:np){
    # begin photo j for child i
    bp[j]<-as.numeric(na.omit(data$age[as.numeric(data$ic[,10])==j]))
    # end photo j for child i
    ep[j]<-as.numeric(na.omit(data$age[as.numeric(data$ic[,11])==j]))
  }
  for (j in 1:np){
    rect(bp[j],0,ep[j],maxsbr,col = rgb(1,1,1,0),
         border= rgb(0,0,0,0.75))
  }
  
  
  # plot the periods of phototherapy
  for (j in 1:data$npt){
    if(data$tpt[j]==1){colrec=rgb(0.0,0.5,1,1/3)}
    if(data$tpt[j]==2){colrec=rgb(0.8,0.5,0.1,1/2)}
    if(data$tpt[j]==3){colrec=rgb(0,0,0,1/3)}
    rect(data$bpt[j],0,data$ept[j],maxsbr,col = colrec, border= NA)
    
    # plot the phototherapy and exchange transfusion thresholds
    if(data$ega<38){
      lines(data$ap,data$yp,col='dark blue',lty=1,lwd=wd)
      lines(data$ae,data$ye,col='dark red',lty=1,lwd=wd)
      lines(data$ap,data$yp50,col='dark blue',lty=3,lwd=wd)
      lines(data$ae,data$ye50,col='dark red',lty=3,lwd=wd)
    }
    if(data$ega>=38){
      lines(c(c(0,1,4)*24,maxage),c(100,200,350,350),col='dark blue',lty=1,lwd=wd)
      lines(c(c(0,1.75)*24,maxage),c(100,450,450),col='dark red',lty=1,lwd=wd)
      lines(c(c(0,1,4)*24,maxage),c(50,150,300,300),col='dark blue',lty=3,lwd=wd)
      lines(c(c(0,1.75)*24,maxage),c(50,400,400),col='dark red',lty=3,lwd=wd)
    }
    points(data$age,data$sbr,pch=19,lwd=1)
    
  }
  
}


