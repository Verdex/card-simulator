
cc = csc
util = Util/*

all : 
	$(cc) Program.cs $(util)

clean :
	rm -rf *.exe
