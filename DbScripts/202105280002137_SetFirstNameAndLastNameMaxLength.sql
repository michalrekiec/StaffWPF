﻿DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Employees')
AND col_name(parent_object_id, parent_column_id) = 'FirstName';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Employees] ALTER COLUMN [FirstName] [nvarchar](30) NOT NULL
DECLARE @var1 nvarchar(128)
SELECT @var1 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Employees')
AND col_name(parent_object_id, parent_column_id) = 'LastName';
IF @var1 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [' + @var1 + ']')
ALTER TABLE [dbo].[Employees] ALTER COLUMN [LastName] [nvarchar](50) NOT NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202105280002137_SetFirstNameAndLastNameMaxLength', N'StaffWpf.ApplicationDbContext',  0x1F8B0800000000000400E5595F6FDB36107F1FB0EF20E87148ADFCC1802DB05BA44E32186B92224ADBBD15B474768852A42652818D629F6C0FFB48FB0A3BFDA748D9923D27DB3014486DF2EE77C7BBE3F1EEFCE7EF7F8CDFAC22E63C4122A9E013F76474EC3AC0031152BE9CB8A95ABCFAC17DF3FADB6FC65761B4723E567467191D727239711F958ACF3D4F068F1011398A68900829166A1488C823A1F04E8F8F7FF44E4E3C400817B11C677C9F724523C8BFE0D7A9E001C42A25EC4684C064B98E3B7E8EEADC9208644C0298B8BE228BC5A778E13A178C1294EF03C32F8473A18842EDCE3F48F05522F8D28F7181B087750C48B7204C42A9F579433EF400C7A7D901BC86B1820A52A944B423E0C9596911CF64DFCBAE6E6D31B4D915DA56ADB353E7769BB89710934445C095EB98E2CEA72CC9481BC38E0A1F8C2E918C72FCBFE63E722A9AA33A143062B27F47CE34652A4D60C22155096147CEFB74CE68F033AC1FC417E0139E32A6AB898AE25E6B0197DE27228644ADEF61512A3F0B5DC76BF3792663CDA6F114879A717576EA3AB7289CCC19D451A019C05722819F8043421484EF895290A0136F05074BB22127FB5B49C290C33BE33A3764F50EF8523D4EDCEFF1925CD31584D54229FC03A778C39047252974286708BD254F7499EB6A88BF8A6226D600D275EE81E514F291C6C5951855BB9F75F75F2722BA174C63D6B63F3F90640948F52036D3F8224D0243C9B1D7C4DCD648AC00F789C38AF77F1585B310721BF645E2354DA4EA09C7B3C384A321F91DE9157CA07B60086E62B2DFD0DB918AC8CA902ED1F81556F6F981467B28466544A524AC1B6D3BB34F1849D63597C0F0DD5D8399FC24922FB91B0A9CB702EF33E17F23D7E849E430C9A64A24DB924D959086249B0B29454073C58C6CA32BD53EEE150F9D011A1681AD9F13E31B330D8D31B7A02A13F73BCB92DBA1EB4CDB40EB966B839FB86682BAE397C0408173111425C794C88084B63FD156617B05731A245952210CCB2E89599272652740CA031A13D67F04837560F6CC54AB85983B28047896F8FA7D33447A3B51D87AD4E20CD3F5596AEC6921673F7BC8A3900392528D8B3873684E7C39CF3661D5558F61F55A3E85B24C8C665C65E03E28EB7458063437A323A8AC006D0369D58405D384BD01A259C0466A25038D724BCE309D33EC82D647699DC2F2F4B02BA981B56C6BDEACF6D13B12541D004D3BE315FD4CD5F7781B1A9FF10D89634CDF5A2354AE387ED1054D5FF9BB370A5181E105B2A35FA8B5AD256145429660ECA268D4342F37F0492373923D22D330B2C83AC37D43045622ED88B65D584566C5937D2E9FCEAA70DC1C4F8D21AFF16C19457E4CE8F4B9CD9C37A4D903DD51E94D054B23BE39DF6DE62EAA279DBF58B111C69EA1BD95CB2CFB58CF41DBE4831CD2DCA9BDDC51278FDD9DB199F5795CA195D13A88B63C1CAB298C75A866753852FB01D3D1B63F6D9B11CD8A57C734F776D0B35DF8B6146D6F0DC7ACEA611DAC5A1B8EA215C4ADE068965FF8B2596F8449524BAFDF0AE34D1897F9B97F626625EC82C475D0484F34CC92B5BF960AA2514630F27F655346F337BB22B8219C2E40AAA287764F8F4F4E8DF1DBBF6714E64919B2C1F3B0171F05D0CCAE3BB6737A7BCD9F48123C92C46AB0B7621E624033C31A793571BF3ABFFD4356EB1D91EC68566B66D269DBB33EDBF68F44F6F3D9B08907ED1CEAD6BECA18CF9DD92F9F75DE23E72EC15B7DEE1CA32F0F332C09F1B33AD8B0A40BAD9811ED323C59304176BF6CD6EC644EFB409E6722A1374F2F3F26B07BA53DE7207BCD1BB656F0CF365FF82F4D13EC2E6CE898A0674A5014077807E7023D5EC4FCB63E78D31861EB14A14BC8C6CEFD05870CB695CC9E70C854A17320F13C0304BB08C448D37E5CC5589774D940643FB572085A3156D3CCF84254016F68549118C9F20614C1644D2E1245172450B81D809479F6FC48589A1B650EE18CDFA52A4E151E19A2396BD5EED995D9263F9F92B4751EDFC5F9FCF91047403569F6DEDCF1B7296561ADF775479EDF0091DDC5B22EC97CA9B2FA64B9AE91EC5F12370195E6AB53C80360F02098BCE33E79827D74FB20E11D2C49B0AE6AF9CD20FD8E689B7D7C49C93221912C311A7EFC8A311C46ABD77F014D5E183D63200000 , N'6.2.0-61023')
