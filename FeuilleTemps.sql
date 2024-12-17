
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Registration')
DROP TABLE dbo.Registration;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'AssignedRoles')
DROP TABLE dbo.AssignedRoles;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'AuditTB')
DROP TABLE dbo.AuditTB;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'DescriptionTB')
DROP TABLE dbo.DescriptionTB;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Documents')
DROP TABLE dbo.Documents;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'ProjectMaster')
DROP TABLE dbo.ProjectMaster;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Roles')
DROP TABLE dbo.Roles;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TimeSheetAuditTB')
DROP TABLE dbo.TimeSheetAuditTB;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TimeSheetDetails')
DROP TABLE dbo.TimeSheetDetails;
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TimeSheetMaster')
DROP TABLE dbo.TimeSheetMaster;

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


SET IDENTITY_INSERT dbo.Registration ON;
INSERT [dbo].[Registration] ([RegistrationID], [Name], [Mobileno], [EmailID], [Username], [Password], [ConfirmPassword], [Gender], [Birthdate], [RoleID], [CreatedOn], [EmployeeID], [DateofJoining], [ForceChangePassword]) VALUES (1, N'SuperAdmin', N'9998887770', N'SuperAdmin@gmail.com', N'SuperAdmin', N'EcMeUuVrv6U89Ul/imhLmw==', N'EcMeUuVrv6U89Ul/imhLmw==', N'M', CAST(0x0000816500000000 AS DateTime), 3, CAST(0x0000A7E300AFA2EB AS DateTime), N'EMP1', NULL, NULL)
INSERT [dbo].[Registration] ([RegistrationID], [Name], [Mobileno], [EmailID], [Username], [Password], [ConfirmPassword], [Gender], [Birthdate], [RoleID], [CreatedOn], [EmployeeID], [DateofJoining], [ForceChangePassword]) VALUES (47, N'Vassili', N'9998887770', N'demo@gmail.com', N'demouser', N'EcMeUuVrv6U89Ul/imhLmw==', N'EcMeUuVrv6U89Ul/imhLmw==', N'M', NULL, 2, CAST(0x0000A80E01878EB6 AS DateTime), N'EMP47', CAST(0x253E0B00 AS Date), NULL)
INSERT [dbo].[Registration] ([RegistrationID], [Name], [Mobileno], [EmailID], [Username], [Password], [ConfirmPassword], [Gender], [Birthdate], [RoleID], [CreatedOn], [EmployeeID], [DateofJoining], [ForceChangePassword]) VALUES (48, N'demoadmin', N'9998887770', N'demo@gmail.com', N'demoadmin', N'EcMeUuVrv6U89Ul/imhLmw==', N'EcMeUuVrv6U89Ul/imhLmw==', N'M', NULL, 1, CAST(0x0000A80F000160A3 AS DateTime), N'EMP48', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Registration] OFF

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

SET IDENTITY_INSERT [dbo].[TimeSheetMaster] ON
INSERT [dbo].[TimeSheetMaster] ([TimeSheetMasterID], [FromDate], [ToDate], [TotalHours], [UserID], [CreatedOn], [Comment], [TimeSheetStatus]) VALUES (1, CAST(0x333E0B00 AS Date), CAST(0x393E0B00 AS Date), 35, 47, CAST(0x0000A8DD00100525 AS DateTime), N'Approved', 2)
SET IDENTITY_INSERT [dbo].[TimeSheetMaster] OFF

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
GO
SET IDENTITY_INSERT [dbo].[TimeSheetDetails] ON
INSERT [dbo].[TimeSheetDetails] ([TimeSheetID], [DaysofWeek], [Hours], [Period], [ProjectID], [UserID], [CreatedOn], [TimeSheetMasterID], [TotalHours]) VALUES (2, N'Monday', 5, CAST(0x343E0B00 AS Date), 1, 47, CAST(0x0000A8DD0010052F AS DateTime), 1, NULL)
INSERT [dbo].[TimeSheetDetails] ([TimeSheetID], [DaysofWeek], [Hours], [Period], [ProjectID], [UserID], [CreatedOn], [TimeSheetMasterID], [TotalHours]) VALUES (3, N'Tuesday', 5, CAST(0x353E0B00 AS Date), 1, 47, CAST(0x0000A8DD00100530 AS DateTime), 1, NULL)
INSERT [dbo].[TimeSheetDetails] ([TimeSheetID], [DaysofWeek], [Hours], [Period], [ProjectID], [UserID], [CreatedOn], [TimeSheetMasterID], [TotalHours]) VALUES (4, N'Wednesday', 5, CAST(0x363E0B00 AS Date), 1, 47, CAST(0x0000A8DD00100531 AS DateTime), 1, NULL)
INSERT [dbo].[TimeSheetDetails] ([TimeSheetID], [DaysofWeek], [Hours], [Period], [ProjectID], [UserID], [CreatedOn], [TimeSheetMasterID], [TotalHours]) VALUES (5, N'Thursday', 5, CAST(0x373E0B00 AS Date), 1, 47, CAST(0x0000A8DD00100532 AS DateTime), 1, NULL)
INSERT [dbo].[TimeSheetDetails] ([TimeSheetID], [DaysofWeek], [Hours], [Period], [ProjectID], [UserID], [CreatedOn], [TimeSheetMasterID], [TotalHours]) VALUES (6, N'Friday', 5, CAST(0x383E0B00 AS Date), 1, 47, CAST(0x0000A8DD00100532 AS DateTime), 1, NULL)
SET IDENTITY_INSERT [dbo].[TimeSheetDetails] OFF

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

SET IDENTITY_INSERT [dbo].[Roles] ON
INSERT [dbo].[Roles] ([RoleID], [Rolename]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleID], [Rolename]) VALUES (2, N'Users')
INSERT [dbo].[Roles] ([RoleID], [Rolename]) VALUES (3, N'SuperAdmin')
SET IDENTITY_INSERT [dbo].[Roles] OFF

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

SET IDENTITY_INSERT [dbo].[DescriptionTB] ON
INSERT [dbo].[DescriptionTB] ([DescriptionID], [Description], [ProjectID], [TimeSheetMasterID], [CreatedOn], [UserID]) VALUES (1, N'Demo', 1, 1, CAST(0x0000A8DD00100535 AS DateTime), 47)
SET IDENTITY_INSERT [dbo].[DescriptionTB] OFF
Go
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



GO 
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
GO
 Create proc [dbo].[Usp_CheckIsDateAlreadyUsed]
@FromDate date,
@ToDate date,
@UserID int
as
begin

SELECT COUNT(1)
  FROM [TimesheetDB].[dbo].[Expense]
  where ToDate between @FromDate and @ToDate and UserID =@UserID
end


GO 
 Create proc [dbo].[Usp_ChangeTimesheetStatus]
@Status int,
@TimeSheetID int,
@Comment varchar(100)
as
begin
Update dbo.TimeSheetAuditTB
set 
Status = @Status,
Comment = @Comment,
ProcessedDate =getdate()
where TimeSheetID = @TimeSheetID and Status <> 1
end


GO 
 Create proc [dbo].[Usp_UpdateUserRole]  
@RegistrationID int  
as      
begin      
Delete from AssignedRoles where RegistrationID = @RegistrationID  
end


GO 
 Create proc [dbo].[Usp_UpdateTimeSheetStatus]  
@TimeSheetMasterID int,  
@Comment varchar(100),  
@TimeSheetStatus int  
as  
begin  
update TimeSheetMaster  
set TimeSheetMaster.TimeSheetStatus =@TimeSheetStatus,  
TimeSheetMaster.Comment =@Comment  
where TimeSheetMaster.TimeSheetMasterID =@TimeSheetMasterID  
end


GO 
 Create proc [dbo].[Usp_UpdatePasswordbyRegistrationID]
@RegistrationID int,
@Password varchar(100)
as
begin
Update Registration
set Registration.Password = @Password
where Registration.RegistrationID =@RegistrationID
end


GO 
 Create proc [dbo].[Usp_Updatepassword]
@NewPassword varchar(100),
@UserID int
as
begin

update Registration 
set Password = @NewPassword
where Registration.RegistrationID = @UserID  
  
end


GO 
 Create proc [dbo].[Usp_GetWeekTimeSheetDetails]
@TimeSheetMasterID int
as
begin
select TM.DaysofWeek
      ,TM.Hours
      ,TM.Period
      ,PM.ProjectName
      ,TM.CreatedOn
      from TimeSheetDetails TM
Inner join ProjectMaster PM on TM.ProjectID = PM.ProjectID 
where TimeSheetMasterID = @TimeSheetMasterID
end


GO 
 Create proc [dbo].[Usp_GetUsersCountbyAdminByAdminID] 
@AdminID int 
as
begin
 select ApprovalUser,
    count(case when Status = 1 then 1 else NULL end) SubmittedCount,
    count(case when Status = 2 then 1 else NULL end) ApprovedCount,
    count(case when Status = 3 then 1 else NULL end) RejectedCount
from TimeSheetAuditTB
where ApprovalUser = @AdminID 
group by ApprovalUser
end


GO 
 Create proc [dbo].[Usp_GetUsersCountbyAdmin]
@AdminID int 
as
begin
Select Count (1) as UsersCount FROM AssignedRoles where AssignToAdmin =@AdminID  
end


GO 
 Create proc [dbo].[Usp_GetUsersCount]
as
begin
Select Count (1) as UsersCount FROM [TimesheetDB].[dbo].[Registration]where RoleID =2
end

GO 
 Create proc [dbo].[Usp_GetUsernamebyRegistrationID]  
@RegistrationID int  
as  
begin  
SELECT   replace(Name, ' ', '')
FROM Registration  
where RegistrationID =@RegistrationID 
end
GO 
 Create proc [dbo].[Usp_GetUserDetailsByRegistrationID]
@RegistrationID int
as
begin
select
EmployeeID,  
Name,
Mobileno,
EmailID,
Username,
Case when Gender ='M' then 'Male'  when Gender ='F' then 'Female' End Gender,
CONVERT(VARCHAR(10), Birthdate, 101) as Birthdate,
CONVERT(VARCHAR(10), DateofJoining, 101) as DateofJoining
from Registration where RoleID =2 and RegistrationID =@RegistrationID
end

GO 
 Create proc [dbo].[Usp_GetTimeSheetsCountByUserID]   
@UserID int   
as  
begin  
 select UserID,  
    count(case when Status = 1 then 1 else NULL end) SubmittedCount,  
    count(case when Status = 2 then 1 else NULL end) ApprovedCount,  
    count(case when Status = 3 then 1 else NULL end) RejectedCount  
from TimeSheetAuditTB 
where UserID = @UserID   
group by UserID  
end

GO 
 Create proc [dbo].[Usp_GetTimeSheetsCountByAdminID] 
@AdminID int 
as
begin
 select ApprovalUser,
    count(case when Status = 1 then 1 else NULL end) SubmittedCount,
    count(case when Status = 2 then 1 else NULL end) ApprovedCount,
    count(case when Status = 3 then 1 else NULL end) RejectedCount
from TimeSheetAuditTB
where ApprovalUser = @AdminID 
group by ApprovalUser
end

GO 
 Create proc [dbo].[Usp_GetTimeSheetMasterIDTimeSheet]  
@FromDate Date = null,  
@ToDate Date  = null,  
@UserID int  
as  
begin  
  

SELECT [TimeSheetMasterID]  
FROM [TimesheetDB].[dbo].[TimeSheetMaster]  
where FromDate  between @FromDate and @ToDate and UserID = @UserID  
end
GO 
 Create proc [dbo].[Usp_GetTimeSheetbyFromDateandToDateTimeSheet]  
@FromDate date = null,  
@ToDate date  = null
as  
begin  
  
SELECT [TimeSheetMasterID]  
FROM [TimesheetDB].[dbo].[TimeSheetMaster]  
where FromDate  between @FromDate and @ToDate 
end

GO 
 Create proc [dbo].[Usp_GetProjectNamesbyTimeSheetMasterID]
@TimeSheetMasterID int
as
begin

  SELECT 
      TM.ProjectID,
      PM.ProjectName
  FROM [TimeSheetDetails] TM
  inner join ProjectMaster PM on TM.ProjectID =PM.ProjectID 
  where  TM.TimeSheetMasterID =@TimeSheetMasterID 
  group by TM.[ProjectID],PM.ProjectName
end

GO 
 Create proc [dbo].[Usp_GetProjectCount]
as
begin
  Select Count (1) as ProjectCount FROM [TimesheetDB].[dbo].[ProjectMaster]
  end
GO 
 Create proc [dbo].[Usp_GetPeriodsbyTimeSheetMasterID]      
@TimeSheetMasterID int      
as      
begin      
      
SELECT       
      CONVERT(varchar(10),T.Period) as Period    
  FROM [TimesheetDB].[dbo].[TimeSheetDetails] T       
  inner join TimeSheetAuditTB TA on T.TimeSheetMasterID = TA.TimeSheetID  
  where TimeSheetMasterID =@TimeSheetMasterID       
  group by Period      
end
GO 
 Create proc [dbo].[Usp_GetListofUnAssignedUsers]      
      
as      
begin      
      
select * from dbo.Registration R       
where R.RoleID =2 and r.RegistrationID not in (
Select RegistrationID from dbo.AssignedRoles
)    
      
      
--RoleID Rolename      
--1 Admin      
--2 Users      
--3 SuperAdmin      
end
GO 
 Create proc [dbo].[Usp_GetListofAdmins]  
  
as  
begin  
select RegistrationID, UPPER(Name) as Name from Registration where RoleID = 1  
end

GO 
 Create proc [dbo].[Usp_GetHoursbyTimeSheetMasterID]    
@TimeSheetMasterID int   ,
@ProjectID int 
as    
begin    
    
SELECT     
      Hours 
  FROM [TimeSheetDetails]     
  where TimeSheetMasterID =@TimeSheetMasterID and ProjectID =@ProjectID
  
  union all
  
  SELECT     
      SUM(Hours) 
  FROM [TimeSheetDetails]     
  where TimeSheetMasterID =@TimeSheetMasterID and ProjectID =@ProjectID 
end
GO 
 Create proc [dbo].[Usp_GetAdminIDbyUserID]
@UserID int
as
begin
SELECT 
      [AssignToAdmin]
  FROM [TimesheetDB].[dbo].[AssignedRoles] where RegistrationID = @UserID
end
GO 
 Create proc [dbo].[Usp_GetAdminDetailsByRegistrationID]  
@RegistrationID int  
as  
begin  
select  
EmployeeID,    
Name,  
Mobileno,  
EmailID,  
Username,  
Case when Gender ='M' then 'Male'  when Gender ='F' then 'Female' End Gender,  
CONVERT(VARCHAR(10), Birthdate, 101) as Birthdate,  
CONVERT(VARCHAR(10), DateofJoining, 101) as DateofJoining  
from Registration where RoleID =1 and RegistrationID =@RegistrationID  
end
GO 
 Create proc [dbo].[Usp_GetAdminCount]
as
begin
Select Count (1) as AdminCount FROM [TimesheetDB].[dbo].[Registration] where RoleID =1
end

GO 
 Create proc [dbo].[Usp_DisableExistingNotifications]
as
begin

update NotificationsTB
set NotificationsTB.Status ='D'

end

GO 
 Create proc [dbo].[Usp_DeleteTimeSheet]
@TimeSheetID int,
@UserID int
as
begin

Delete from TimeSheetMaster where TimeSheetMasterID =@TimeSheetID and UserID =@UserID

if exists (select TimeSheetID from dbo.TimeSheetDetails where TimeSheetID =@TimeSheetID and UserID =@UserID)
begin
Delete from TimeSheetDetails where TimeSheetID =@TimeSheetID and UserID =@UserID
end

if exists (select TimeSheetID from dbo.TimeSheetAuditTB where TimeSheetID =@TimeSheetID and UserID =@UserID)
begin
Delete from TimeSheetAuditTB where TimeSheetID =@TimeSheetID and UserID =@UserID
end
	
end


GO 
 Create proc [dbo].[GetUserIDbyTimeSheetID]
@TimeSheetMasterID int
as
begin
select top 1 UserID from TimeSheetMaster where TimeSheetMasterID =@TimeSheetMasterID
end
GO 
 Create proc [dbo].[GetDescriptionbyTimeSheetMasterID]      
@TimeSheetMasterID int   ,  
@ProjectID int   
as      
begin      
select Description from DescriptionTB where TimeSheetMasterID =@TimeSheetMasterID and ProjectID =@ProjectID  
end

