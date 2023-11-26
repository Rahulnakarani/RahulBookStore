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
20231104222825_AddCategoryToDb.cs
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

2023-11-04 1909
Updated CategoryRepository.cs

2023-11-04 1912
Updated ICategoryRepository.cs

2023-11-04 1944
Created ISP_Call.cs

2023-11-04 2008
Created and updated SP_Call.cs

2023-11-05 0645
Created IUnitOfWoek Interface in IRepository

2023-11-05 0650
Created UnitOfWork Class in Repository

2023-11-05 0654
Updated Startup.cs

2023-11-05 0700
Runned the Application 

Works fine

2023-11-05 0712
Created CategoryController in Admin area

2023-11-05 0727
Added Index.cshtml in Views folder

Running the application

cannot see the view

[Area("Admin")] Forgot to put this in controller

2023-11-05 0909
Uodated controller and added upsert method

Created Partial Views

2023-11-05 0954
Updated categoryController.cs file

2023-11-05 1022
Added functionality for edit and delete category

2023-11-05 1038
Updated Delete functionality

Added sweet alert in Category.js

2023-11-05 1045
Project runs successfully


2023-11-16 1802
==================================================================
                 Assignment 2 part 1 overview
==================================================================
The inception of the RahulBookStore project involved the creation of two crucial files—README.txt 
for tracking changes and README.md for general project information. To facilitate version control and collaboration, a dedicated GitHub 
repository named RahulBookStore was established, serving as the central hub for updates. Leveraging a theme sourced from bootswatch.com, 
the project's aesthetic and functional aspects were enhanced. The project structure expanded with the inception of three subprojects: 
RahulBooks.DataAccess, RahulBooks.Models, and RahulBooks.Utility, each mirroring specific folders from the primary project. This segmentation 
facilitated a more organized workflow. The project's functionality was augmented by the integration of essential NuGet packages, ensuring 
smooth operations. Furthermore, intricate connections were forged between the projects by setting up references, fostering a cohesive 
ecosystem. Dividing the main project into distinct areas—Customer and Admin—enabled streamlined navigation and management, laying the 
groundwork for future development and expansion.


==================================================================
                 Assignment 2 part 2 overview
==================================================================
The initial phase involved NuGet console-driven migrations, specifically AddDefaultIdentityMigration and AddCategoryToDb, aimed at 
establishing fundamental and Categories table structures, respectively, followed by executing the update-database command for database 
updates. Within Rahulbooks.Models, the addition of models, notably Category.cs, laid the groundwork. The project structure expanded with 
the introduction of a Repository folder housing essential interfaces—IRepository.cs, ICategoryRepository.cs, ISP_Call.cs, IUnitOfWork.cs—which 
were subsequently implemented in respective class files—Repository.cs, CategoryRepository.cs, SP_Call.cs, UnitOfWork.cs.

the introduction of CategoryController.cs facilitated administrative control, while modifications in views emerged. Key additions included 
Index.cshtml, presenting categories, and modifications in _Layout.cshtml, incorporating categories within dropdown menus. Moreover, 
Upsert.cshtml emerged as the central hub for managing categories, equipped with functionalities for adding, updating, and deleting 
categories. These functionalities were reinforced by intricate modifications in both Upsert.cshtml and category.js, the latter leveraging 
SweetAlert for streamlined and visually appealing alerts, enhancing user experience during category management.

2023-11-16 1907
Ran the application before implementing the part 3
Yay!!! Application runs fine without any error.

2023-11-16 1915
Created CoverType.cs in RahulBooks.Models for CRUD operation and Added two field Id and Name with validation.

2023-11-16 1923
Added interface file named ICoverTypeRepository.cs in IRepository folder and Class file name CoverTypeRepository into Repository folder. and made them public so that
they can be accessed across the entire project.
Now I am not sure what to add in those files.

2023-11-16 1931
Updated ICovertyprRepository.cs and made it like ICategoryRepository.cs with the class CoverType.

2023-11-16 1937
Updated CovertyprRepository.cs and made it like CategoryRepository.cs with the class CoverType. And implemented the interface and updated the update method

2023-11-16 1943
Added CoverType into UnitOfWork.cs and IUnitOfWork.cs files

2023-11-16 1944
Added this line to ApplicationDbContext.cs
        public DbSet<CoverType> CoverType { get; set; }


2023-11-16 1947
Added migartion called Add CoverTypeToDb using nuGet console.
Command: add-migration AddCoverTypeToDb
File name: 20231117021717_AddCoverTypeToDb.cs
updated the database using update-database command

2023-11-16 1955
Updated _Layout.cshtml. Added covertype in the dropdown menu.

2023-11-16 2004
Created new Controller named CoverTypeController.cs in Admin area
Created Folder called CoverType and created index.cshtml file inside the same folder.
Added same data as index.cshtml file for thr category with slight changes.

2023-11-16 2014
Updated CoverTypeController and added neccessory method for CRUD oprations.
create Upsert.cshtml

2023-11-16 2039
Updated Upsert.cshtml added content from Upsert.cshtml from category.
Created covertype.js to show thw table data and for the delete API calls.
Linked js file to the Index.cshtml

2023-11-16 2053
updated Upsert.cshtml

2023-11-16 2123
Created Product.cs file and Added the info as shown in th slides.
Added this line to ApplicationDbContext.cs       
        public DbSet<Product> Products { get; set; }
Added Migration name Add-migration AddProductToDb
File Name: 20231117022248_AddProductToDb.cs
Updated Database

2023-11-16 2138
Added validation for Title, ISBN, Author in Product.js
Added Migration named AddValidationToProduct
File name: 20231117023238_AddValidationToProduct.cs
Updated Database

2023-11-16 2209
Created class file ProductRepository.cs and interface IProductRepository.cs
Implemented interface in class file
Edited Update method as given in slides

2023-11-16 2014
Included product in UnitOfWork and IUnitOfWork

2023-11-16 2015
Runnning Final Build for the day
Build is successful

2023-11-17 1648
Created ProductController.cs in Admin Area.
Added IUnitofWork and WebHostEnvironment object
Created ProductVM in RahulBooks.Models

2023-11-17 1659
Updated ProductVM.cs file
Had to install a package named Microsoft.AspNetCore.Mvc.ViewFeatures

2023-11-17 1723
Updated ProductController.cs
added Upsert method and API Calls.
GetAll() and Delete()

2023-11-17 1738
Created Index.cshtml view
Copied content from Catrgory/index.cshtml
Added table headers.
created product.js file
Copied content from category.js
Updated links

2023-11-17 1748
Updated _Layout.cshtml
Added <a class="dropdown-item" asp-area="Admin" asp-controller="Product" asp-action="Index">Product</a>
Updated product.js
Forgot to update Info in index.cshtml

2023-11-17 1814
Added code for tiny cloud in upsert.cshtml

2023-11-17 1816
Running an application
Run is successful

2023-11-17 1822
created two folders in wwwroot images/products
Uncommented Upsert from ProductController.cs
To update the method no file is given in Assignment 2 files
Final build and run
Getting an error must be because of the upsert method

2023-11-21 1121
Finally figured out the error 
Forgot to add one line in UnitOfWork "Product = new ProductRepository(_db);"


2023-11-26 1129
Starting Part 4
Compared Whole project with product given by the Proff.

2023-11-26 1130
Updated Product.cs
Added New fields Price, Price50, Price100 with validations
Changed Foreign key for CovertypeId

2023-11-26 1211
Added Migration UpdateProductTable
Updated Databse
Command: add-migration UpdateProductTable
File Name: 20231126171120_UpdateProductTable.cs

2023-11-26 1240
Updated SD.cs in Utility Project

2023-11-26 1243
Updated ProductRepository.cs
Added 3 lines for the new fields created
              objFromDb.Price = product.Price;
              objFromDb.Price50 = product.Price50;
              objFromDb.Price100 = product.Price100;

2023-11-26 1256
Updated ProductController.cs
Updated Upsert and Delete API

2023-11-26 1321
Updated Admin/Views/Product/Upsert.cshtml
Added Labels and input fields for new data fields added in Table products.
Price, Price50, Price100
Changed this line for the dropdown
@Html.DropDownListFor(m => m.Product.CoverTypeId, Model.CoverTypeList, "-Select a Cover Type",
                   new { @class = "form-control" })
                    <span asp-validation-for="Product.CoverTypeId" class="text-danger"></span>