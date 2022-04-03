

CREATE TABLE [dbo].[VATTreatment31_Menu](
	
	[MenuCode] [varchar](10) NOT NULL, --PK
	[Active] [bit] NOT NULL,
	[ParentMenuCode] [varchar](10) NULL,	
	[DateInsert] [datetime2](3) NOT NULL,
	[CaptionFR] [varchar](300) NOT NULL,
	[CaptionNL] [varchar](300) NOT NULL,
	[VatId] [int] NOT NULL REFERENCES [dbo].[VATTreatment](VATTRT_ID),

	CONSTRAINT [PK_VATTreatment31_Menu] PRIMARY KEY CLUSTERED --define PK
	(
		[MenuCode] ASC
	)
	WITH 
	(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]
) 

ALTER TABLE [dbo].[VATTreatment31_Menu] ADD  CONSTRAINT [DF_VATTreatment31_Menu_DateInsert]  DEFAULT (getdate()) FOR [DateInsert]
GO	--insert the date automatically

--
EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Hierarchy of Menu (domain and reason in the web page)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VATTreatment31_Menu'
GO

EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Unique identifier of Menu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'MenuCode'
GO

EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Id of own MenuId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'ParentMenuCode'
GO

EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'DB generated record insertion date time' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'DateInsert'
GO


EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'French language user description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',
@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'CaptionFR'
GO

EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'Dutch language user description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',
@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'CaptionNL'
GO

EXEC sys.sp_addextendedproperty @name=N'Description', @value=N'default vat value for the menu item' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',
@level1name=N'VATTreatment31_Menu', @level2type=N'COLUMN',@level2name=N'VatId'
GO

