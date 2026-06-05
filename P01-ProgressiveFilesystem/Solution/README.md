
## Instructions

Welcome to the practice task! This task is designed to be a playground that allows you to get acquainted with the testing environment and practice the functionalities of the platform before your real assessment. Your task is to implement a simple container of integer numbers. All operations that should be supported by this database are described below.

_Solving this task consists of several levels. Subsequent levels are opened when the current level is correctly solved. You always have access to the data for the current and all previous levels._

_You are not required to provide the most efficient implementation. Any code that passes the unit tests is sufficient._

**Environment details**  (click here to hide)

To read the details about the language version, libraries used in the task, and the testing framework, used check out the  `README`  tab![](https://codesignal-assets.s3.amazonaws.com/uploads/1686256985124/Readme_Tab.png)in the left panel of the page.

To customize the editor settings and see the editor hotkeys, check out the  `SETTINGS`  tab![](https://codesignal.s3.amazonaws.com/uploads/1631189051853/IDE_Settings.png)in the left panel of the page.

To reset your code, click![](https://codesignal-assets.s3.amazonaws.com/uploads/1686255971976/Reset_Code.png)button in the top right corner of the page. Be careful, this will reset all your code changes!

Unit tests are already implemented and cannot be modified. You can find level 1 tests among the open files. Feel free to look at them and get familiar with the details. There is also an editable sandbox test file, which can be used for testing your code with custom test cases. These tests will be run together with other tests but will not be taken into account for scoring.

To run the tests, you can choose either  `In Terminal`  or  `Structured`  option from the dropdown![](https://codesignal-assets.s3.amazonaws.com/uploads/1686258632086/Tests_Dropdown.png)and click![](https://codesignal-assets.s3.amazonaws.com/uploads/1686258495699/Run_Tests.png)button located on the right part of the screen. The difference between these options is the format of the test results:

-   If you'd like to receive a raw report of tests, choose the  `In Terminal`  option. The tests in this report will contain all debug output you've printed to the console.
-   If you'd like to receive test results with more structure, choose the  `Structured`  option. Note that debug output is not supported in this option.

You can execute a single test case by running the following command in the terminal:  `bash run_single_test.sh "<test_case_name>"`.

## Requirements

Your task is to implement a simple container of integer numbers. Plan your design according to the level specifications below:

-   **Level 1: Container should support adding and removing numbers.**
-   Level 2: Container should support getting the median of the numbers stored in it.

To move to the next level, you need to pass all the tests at this level when submitting the solution.

## Level 1

Implement two operations for adding and removing numbers from the container. Initially, the container is empty.

-   **`int Add(int value)`**  — should add the specified integer  `value`  to the container and return the number of integers in the container after the addition.
    
-   **`bool Delete(int value)`**  — should attempt to remove the specified integer  `value`  from the container. If the  `value`  is present in the container, remove it and return  `true`, otherwise, return  `false`.
    

## Examples

The example below shows how these operations should work (the section is scrollable to the right):

Queries

Explanations

```
Add(5)
Add(10)
Add(5)
Delete(10)
Delete(1)
Add(1)

```

```
returns 1; container state: [5]
returns 2; container state: [5, 10]
returns 3; container state: [5, 10, 5]
returns true; container state: [5, 5]
returns false; container state: [5, 5]
returns 3; container state: [5, 5, 1]

```

-   **[execution time limit] 40 seconds**
    
-   **[memory limit] 4g**