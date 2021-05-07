CREATE TABLE [dbo].[Cars] (
         [CarId] int not null, 
         [BrandId] int not null,
        [ColorId] int not null,
         [ModelYear] int not null,

         [DailyPrice] int not null,

         [Description] nvarchar(50) not null
);
