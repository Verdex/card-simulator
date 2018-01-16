
cc = csc
util = Util/*
gems = Gems/*

all : 
	$(cc) Program.cs $(util) $(gems)

clean :
	rm -rf *.exe
