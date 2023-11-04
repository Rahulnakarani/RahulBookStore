Program Name: RahulsBookStore
Program Purpose: Website for Books
Program Author: Rahul Nakarani
Date Created: 2023-10-28 1810[ISO Date]

2023-10-28 1810
Created RahulsBookStore project in Visual Studio 2019

2023-10-28 1822
Created README.txt and README.md

2023-10-28 1827
Created Git hub Repository and pushed it

2023-10-28 1828
Removed a line from Startup.cs
options => options.SignIn.RequireConfirmedAccount = true

2023-10-28 1845
Added two breakpint in HomeController.cs
and Debugged code successfully

2023-10-28 1856
Replaced bootstrap.css with the downloaded theme

2023-10-28 1909
Updated _layout.cshtml and _LoginPartial.cshtml for the new theme

2023-10-28 1944
Addedsome aditional links to the layout.cshtml and dropdown menu in navigaion bar

2023-10-28 1951
oops, forgot to replace site.css with the new one

2023-10-28 1853
cannot figureout why the dropdown isnot working

2023-10-28 1950
finally figured out the solution for the dropdown
had to add "data-toggle="dropdown" aria-haspopup="true" aria-expanded="false""

2023-10-28 2017
Added 3 new projects

2023-10-28 2032
Installed 3 packages
Microsoft.EntityFrameworkCore.Relational
Microsoft.EntityFrameworkCore.SqlServer
Identity.EntiryFrameworkCore

Deleted Migration folder from Data

2023-10-28 2037
Deleted class1.cs from every project

2023-10-28 2041
Moved Models folder to RahulsBooks.Models

Added project references

Renamed Models to ViewModels

2023-10-28 2111
Added namespace for the errorviewmodels

2023-10-28 2114
Build Successfull.

2023-10-28 2119
Added SD.cs class file in utility project

Updated class definition

2023-10-28 2124
Added reference of utitlity to main project

Added reference of models and utility to dataaccss project

2023-10-28 2142
Added Cutomer area

and done neccessory changes into the area

2023-10-28 2159
Getting this exception 
InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type. Register the constraint type with 'Microsoft.AspNetCore.Routing.RouteOptions.ConstraintMap'.

2023-10-28 2214
Error solved. There was a mistake in startup.cs

2023-10-28 2220
Craeted Admin Area

Added view file 

2023-10-28 2225
Build is successfull
Application Runs successfully

2023-11-04 1755
Created Migration with NuGet Console

add-migration AddDefaultIdentityMigration

Migration Files
20231104215434_AddDefaultIdentityMigration.cs
ApplicationDbContextModelSnapshot.cs

2023-11-04 1759
Updated Database

update-database

2023-11-04 1808
Created Category.cs file in .Models project

2023-11-04 1810
Added Migration

add-migration AddCategoryToDb

2023-11-04 1829
Was getting duplication error took some time to figure out the solution
Error: The name 'AddCategoryToDb' is used by an existing migration
solution: Deleted the already created file and re run the command to add migration

2023-11-04 1832
updated database

2023-11-04 1841
Added new interface called IRepository.cs in .DataAccess
Modified it for CRUD

2023-11-04 1846
Completed IRepository.cs

2023-11-04 1855
Created Repository.cs

2023-11-04 1902
Created two files 
	ICategoryRepository.cs
	CategoryRepository.cs

2023-11-04 1709
Updated CategoryRepository.cs

2023-11-04 1712
Updated ICategoryRepository.cs