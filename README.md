## LeapYear
This is a sample of F# script.


### Usage
```
% dotnet fsi LeapYear.fsx 2024
```

### Appendix
You can use this in shell script like this:
```
% if [ `dotnet fsi LeapYear.fsx 2024` = "true" ];then echo "Happy Leap Year"; else echo "Happy New Year";fi
```

If you add the following alias to your .bashrc or .zshrc
```
alias dnfsi='dotnet fsi'
```
you can call the script just like this:
```
% dnfsi LeapYear.fsx 2024
```
