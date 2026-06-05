
Welcome to the pre-certification practice task! This task is designed to be a playground that allows you to get acquainted to the testing environment and practice the functionalities of the platform before your certification.

To customize the editor settings and see the editor hotkeys, check out the  `IDE Settings`  tab![](https://codesignal.s3.amazonaws.com/uploads/1631189051853/IDE_Settings.png)in the lower left corner of the page.

## Scenario

Your task is to implement a simple container of integer numbers. You are given a class  `Container`  which implements the interface  `IContainer`  within the  `IContainer.cs`  file. You should implement any empty methods of this class, which correspond to the operations described below.

Unit tests are already implemented in the  `BasicTests.cs`  and  `ContainerTests.cs`  files, so feel free to open them and get familiar with the details. Note that these unit tests use the  `Xunit`  framework. To run these tests, you can use the following options associated with the  `RUN`  button located in the bottom-right corner:

![](https://codesignal.s3.amazonaws.com/uploads/1627282399069/Screen_Shot_2021-07-26_at_10.03.37.png)

-   If you'd like to receive a raw report on tests, choose the  `In Terminal`  option. The tests in this report will always be ordered in the same way, and will contain all debug output you've printed to the console.
-   If you'd like to receive test results with more structure, choose the  `Structured`  option. Note that debug output is not supported by this option.
-   If you'd like to run your project in a custom way, choose the  `Run Custom Script`  option. This will create a new  `main.sh`  file that is expected to contain the compilation and execution logic. The  `Run Custom Script`  button will execute this custom script when clicked.
    -   For example, you can use the following script to execute the first basic test only:
        -   `dotnet test --filter FullyQualifiedName=Container.Tests.BasicTests.TestBasic1`
-   For more information, check out the  `Readme`  tab![](https://codesignal.s3.amazonaws.com/uploads/1631189629956/Screen_Shot_2021-09-09_at_16.12.34.png)on the left.

Partial credit will be granted for each unit test passed, so press  **Submit**  often to run tests and receive partial credits for passed tests. Please check tests for requirements and argument types.

## Operations

The program starts with an empty container.

-   **ADD <value>**  should add the specified integer  `value`  to the container.
    
-   **DELETE <value>**  should attempt to remove the specified integer  `value`  from the container. If the  `value`  is present in the container, remove it and return  `true`, otherwise, return  `false`.
    
-   **GET_MEDIAN**  should return the median integer - the integer  `value`  in the middle of the sequence after all integer  `value`  stored in the container are sorted from smallest to largest. If the length of the sorted sequence is even, the leftmost integer from the two middle integers should be returned. If the container is empty, this method should raise a runtime exception.
    

-   **[execution time limit] 15 seconds**
    
-   **[memory limit] 4g**