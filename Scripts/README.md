Some tools to Save Time
============
### graphql

1. install dotnet core
2. `cd Scripts/graphql`
3. `dotnet build`
4. if you want to generate problem [Triangle](https://leetcode.com/problems/triangle), which's number is 120.
   so, just run:   
   `dotnet run 120`
5. enjoy it!

--- 

 OBSOLETE

### auto.ps1

`auto.ps1` - it's used to generate files include author,problem description, comments, test code and so on.

> **Notes**:

> - The  `auto.ps1`  is support both Mac and Windows platfrom.

> - The  `auto.ps1`  require [powershell](https://github.com/PowerShell/PowerShell) and [pup](https://github.com/ericchiang/pup). 

First you need to launch a `powershell` session from a terminal.

Run powershell command as the following:

```
PS /Users/codeyu/github/leetcode/Scripts> ./auto.ps1 https://leetcode.com/problems/next-permutation/
```

The NextPermutation.cs and NextPermutationTest.cs files would be generated by above command.

--- 

 OBSOLETE
 
### Fork from [haoel's leetcode](https://github.com/haoel/leetcode)

### thanks &hearts; @haoel


### comments.sh

`comments.sh` - it's used to generate author and problem description comments 

> **Notes**: 
> - The  `comments.sh`  is compatible for both Linux and Mac platfrom.
> - The  `comments.sh`  needs [xidel](http://videlibri.sourceforge.net/xidel.html) to grab & parse the html  contents with filtering out the HTML tags. The script  would check the `xidel`  whether installed or not in your Linux box, if not, it will download the [Universal Linux Version](http://videlibri.sourceforge.net/xidel.html#downloads) on Linux platform, and the [Mac OS Prebuilt Version](https://www.evernote.com/shard/s69/sh/ff1e78f3-a369-4855-b18f-6184ce789c45/f3511927d0fb356ce883835f2eb712e0) on Mac platfrom.
> - The  `comments.sh`  currently can automatically detect the problem's type, if the problem is `algorithm` type, it's going to create `.cpp` file, if the problem is `shell` type, the `.sh` file will be created.

1) Create a file named largestNumber.cpp, and add Copyright & Problem description
```
./comments.sh https://leetcode.com/problems/largest-number/
```

2) Add Copyright & Problem description into existed file
```
./comments.sh https://leetcode.com/problems/largest-number/ largestNumber.cpp
```

The comments would be generated by above examples as below:

> **Notes**
> If you need to customize the `Author` name, you have to change the `$AUTHOR` variable at the beginning of the scripts.

```
// Source : https://oj.leetcode.com/problems/largest-number/
// Author : Hao Chen
// Date   : 2015-01-25

/**********************************************************************************
 *
 * Given a list of non negative integers, arrange them such that they form the largest number.
 *
 * For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.
 *
 * Note: The result may be very large, so you need to return a string instead of an integer.
 *
 * Credits:Special thanks to @ts for adding this problem and creating all test cases.
 *
 **********************************************************************************/


```

### readme.sh

`readme.sh` - it's used to generate the table item in README.md

For example:

```
$  ./readme.sh ../Algorithms/TwoSumTest.cs
|001|[Two Sum](https://leetcode.com/problems/two-sum/) | [C#](./Algorithms/TwoSum.cs)|Easy|
```

