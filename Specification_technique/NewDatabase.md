CREATE TABLE [dbo].[Registration](
	[RegistrationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Mobileno] [varchar](20) NULL,
	[EmailID] [varchar](100) NULL,
	[Username] [varchar](20) NULL,
	[Password] [varchar](100) NULL,
	[ConfirmPassword] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[Birthdate] [datetime] NULL,
	[RoleID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[EmployeeID] [varchar](10) NULL,
	[DateofJoining] [date] NULL,
	[ForceChangePassword] [int] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[RegistrationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[TimeSheetMaster](
	[TimeSheetMasterID] [int] IDENTITY(1,1) NOT NULL,
	[FromDate] [date] NULL,
	[ToDate] [date] NULL,
	[TotalHours] [int] NULL,
	[UserID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[Comment] [varchar](100) NULL,
	[TimeSheetStatus] [int] NULL,
 CONSTRAINT [PK_TimeSheetMaster] PRIMARY KEY CLUSTERED 
(
	[TimeSheetMasterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[TimeSheetDetails](
	[TimeSheetID] [int] IDENTITY(1,1) NOT NULL,
	[DaysofWeek] [varchar](50) NULL,
	[Hours] [int] NULL,
	[Period] [date] NULL,
	[ProjectID] [int] NULL,
	[UserID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[TimeSheetMasterID] [int] NULL,
	[TotalHours] [int] NULL,
 CONSTRAINT [PK_TimeSheetDetails] PRIMARY KEY CLUSTERED 
(
	[TimeSheetID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[AuditTB](
	[AuditID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](50) NULL,
	[SessionID] [varchar](50) NULL,
	[IPAddress] [varchar](50) NULL,
	[PageAccessed] [varchar](200) NULL,
	[LoggedInAt] [datetime] NULL,
	[LoggedOutAt] [datetime] NULL,
	[LoginStatus] [varchar](200) NULL,
	[ControllerName] [varchar](200) NULL,
	[ActionName] [varchar](200) NULL,
	[UrlReferrer] [varchar](200) NULL,
 CONSTRAINT [PK_AuditTB] PRIMARY KEY CLUSTERED 
(
	[AuditID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[TimeSheetAuditTB](
	[ApprovalTimeSheetLogID] [int] IDENTITY(1,1) NOT NULL,
	[ApprovalUser] [int] NULL,
	[ProcessedDate] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[Comment] [varchar](100) NULL,
	[Status] [int] NULL,
	[TimeSheetID] [int] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_TimeSheetAuditTB] PRIMARY KEY CLUSTERED 
(
	[ApprovalTimeSheetLogID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Rolename] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[ProjectMaster](
	[ProjectID] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [varchar](100) NULL,
	[NatureofIndustry] [varchar](100) NULL,
	[ProjectCode] [varchar](10) NULL,
 CONSTRAINT [PK_ProjectMaster] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[NotificationsTB](
	[NotificationsID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
 CONSTRAINT [PK_NotificationsTB] PRIMARY KEY CLUSTERED 
(
	[NotificationsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[DescriptionTB](
	[DescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NULL,
	[ProjectID] [int] NULL,
	[TimeSheetMasterID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_DescriptionTB] PRIMARY KEY CLUSTERED 
(
	[DescriptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Documents](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentName] [varchar](50) NULL,
	[DocumentBytes] [varbinary](max) NULL,
	[UserID] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ExpenseID] [int] NULL,
	[DocumentType] [varchar](10) NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[AssignedRoles](
	[AssignedRolesID] [int] IDENTITY(1,1) NOT NULL,
	[AssignToAdmin] [int] NULL,
	[Status] [varchar](1) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[RegistrationID] [int] NULL,
 CONSTRAINT [PK_AssignedRoles] PRIMARY KEY CLUSTERED 
(
	[AssignedRolesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
