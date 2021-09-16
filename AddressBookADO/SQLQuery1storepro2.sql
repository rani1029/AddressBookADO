use AddressBook
go

Create procedure spAddContact                                           
           ( @PhoneNumber float,
	@AddressBookName varchar(40),
	@FirstName varchar(40) ,
	@LastName varchar(40),
	@Email varchar(30),
	@Address varchar(250),
	@City varchar(60),
	@State varchar(100),
	@Zip int 	
	)               
            
as  
BEGIN TRY                       
   
   INSERT INTO PersonDetails(PhoneNumber ,AddressBookName, FirstName,LastName,Email)
VALUES
(@PhoneNumber,@AddressBookName,@FirstName,@LastName,@Email);
INSERT INTO PersonAddress(PhoneNumber ,Address, City,State,Zipcode)
VALUES
(@PhoneNumber,@Address,@City,@State,@Zip);

END TRY  
BEGIN CATCH
  SELECT
    ERROR_NUMBER() AS ErrorNumber
    
END CATCH          
go

