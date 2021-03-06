SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_CIUDAD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_CIUDAD](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_MARCA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_MARCA](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_TIPO_MOVIMIENTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_TIPO_MOVIMIENTO](
	[codigo] [int] NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Tipo_Mov] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_KARDEX]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_DET_KARDEX](
	[numero] [int] NOT NULL,
	[producto] [int] NOT NULL,
	[bodega] [int] NOT NULL,
	[linea] [int] NOT NULL,
	[tipo_movimiento] [int] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
	[cantidad] [int] NOT NULL,
	[valor_unitario] [real] NOT NULL,
	[valor_total] [real] NOT NULL,
 CONSTRAINT [PK_TBL_INV_DET_KARDEX] PRIMARY KEY CLUSTERED 
(
	[producto] ASC,
	[bodega] ASC,
	[linea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_CAB_KARDEX]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_CAB_KARDEX](
	[numero] [int] NOT NULL,
	[bodega] [int] NOT NULL,
	[producto] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[existencia_actual] [int] NOT NULL,
	[existencia_minima] [int] NOT NULL,
	[existencia_maxima] [int] NOT NULL,
	[responsable] [int] NOT NULL,
 CONSTRAINT [PK_TBL_INV_CAB_KARDEX_1] PRIMARY KEY CLUSTERED 
(
	[bodega] ASC,
	[producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_ING_CAB_ORDEN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[INV_ING_CAB_ORDEN]
@numero INT,
@Bodega int, @Responsable int, @Fecha_Pedido datetime,
@Fecha_Entrega datetime, @Observación nvarchar(30)
AS
BEGIN
 insert into TBL_INV_CAB_ORDEN_PEDIDO 
values (@numero, @Bodega, @Responsable, @Fecha_Pedido, @Fecha_Entrega, @Observación)
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_InDetKardex]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE Procedure [dbo].[SP_InDetKardex]
(
		@bodega int,
		@producto int,
		@linea int,
		@tipo_movimiento int,
		@fecha_registro datetime,
		@cantidad int,
		@valor_unitario money,
		@valor_total money
	
)
AS
	--set @linea = (select isnull(max(linea),0)+1 from tbl_inv_det_kardex where cab_kardex = @cab_kardex)	''	
INSERT into TBL_INV_DET_KARDEX 
			VALUES(@bodega,@producto,@linea,@tipo_movimiento,@fecha_registro,@cantidad,@valor_unitario,@valor_total)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Conkardex]') AND type in (N'P', N'PC'))
--BEGIN
--EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Conkardex]
--	@numero int,
--	@cab_kardex int
--AS
--BEGIN
--	select a.numero, a.bodega, a.producto, a.fecha, a.existencia_actual, a.existencia_minima, a.responsable,
--			b.linea, b.tipo_movimiento, b.fecha_registro, b.responsable, b.observacion, b.cantidad,
--			b.valor_unitario, b.valor_total
--	 from TBL_INV_CAB_KARDEX a inner join TBL_INV_DET_KARDEX b
--	 on @numero = @Cab_Kardex
--END
--' 
--END
--GO
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModCabkardex]') AND type in (N'P', N'PC'))
--BEGIN
--EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModCabkardex]
--(
--		@numero int,
--		@bodega int,
--		@producto int,
--		@fecha  datetime,
--		@existencia_actual int,
--		@existencia_minima int,
--		@existencia_maxima int,
--		@responsable nvarchar(30)
--)
--AS

--	IF EXISTS (SELECT 1 FROM TBL_INV_CAB_KARDEX
--				WHERE numero = @numero)
--		UPDATE TBL_INV_CAB_KARDEX
--		SET bodega = @bodega,
--			producto=@producto,
--			fecha=@fecha,
--			existencia_actual=@existencia_actual,
--			existencia_minima=@existencia_minima,
--			existencia_maxima=@existencia_maxima,
--			responsable=@responsable
--		WHERE numero = @numero
--	ELSE
--		RAISERROR(''Parametro no existe'',16,1)' 
--END
--GO
--SET ANSI_NULLS ON
--GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_ESTADO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_ESTADO](
	[Código] [int] IDENTITY(1,1) NOT NULL,
	[Descripción] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Código] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_GRUPO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_GRUPO](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Grupo] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_BODEGA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_BODEGA](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_ZONA]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_ZONA](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[ciudad] [int] NULL,
	[nombre] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Zona] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_PRODUCTO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_PRODUCTO](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[grupo] [int] NOT NULL,
	[subgrupo] [int] NOT NULL,
	[marca] [int] NOT NULL,
	[presentacion] [nvarchar](30) NOT NULL,
	[observacion] [nvarchar](40) NULL,
	[iva] [nvarchar](5) NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_DIRECCION]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_DIRECCION](
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[bodega] [int] NULL,
	[zona] [int] NULL,
	[calle_principal] [nvarchar](30) NOT NULL,
	[calle_transversal] [nvarchar](30) NOT NULL,
	[descripcion_amplia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Dirección] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_ORDEN_PEDIDO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_DET_ORDEN_PEDIDO](
	[numero] [int] NOT NULL,
	[bodega] [int] NOT NULL,
	[linea] [int] NOT NULL,
	[producto] [int] NULL,
	[cantidad] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_Det_Orden] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[bodega] ASC,
	[linea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_SUBGRUPO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_SUBGRUPO](
	[codigo] [int] NOT NULL,
	[grupo] [int] NOT NULL,
	[descripcion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Subgrupo] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC,
	[grupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBL_INV_CAB_ORDEN_PEDIDO]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TBL_INV_CAB_ORDEN_PEDIDO](
	[numero] [int] NOT NULL,
	[bodega] [int] NOT NULL,
	[responsable] [int] NULL,
	[fecha_pedido] [datetime] NOT NULL,
	[fecha_entrega] [datetime] NOT NULL,
	[observacion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cab_Orden] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[bodega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_Ciudad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_Ciudad]
	@codigo int
AS
BEGIN
	select nombre from TBL_INV_CIUDAD 
	where codigo=@codigo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngCiudad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_IngCiudad]
(
		@nombre nvarchar(30)
)
AS
		INSERT TBL_INV_CIUDAD (nombre)
			VALUES(@nombre)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModCiudad]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModCiudad]
(
		@codigo int,
		@nombre nvarchar(30)
)
AS

	IF EXISTS (SELECT 1 FROM TBL_INV_CIUDAD 
				WHERE codigo = @codigo)
		UPDATE TBL_INV_CIUDAD
		SET nombre = @nombre
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_CiudadxZona]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_CiudadxZona]
	@codigo int
AS
BEGIN
	select d.ciudad, a.codigo,a.nombre
	from TBL_INV_ZONA d inner join TBL_INV_CIUDAD a
	on (a.codigo = @codigo) and (d.ciudad = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vt_kardex]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vt_kardex]
AS
SELECT     dbo.TBL_INV_BODEGA.nombre, dbo.TBL_INV_CAB_KARDEX.fecha, dbo.TBL_INV_CAB_KARDEX.existencia_actual, dbo.TBL_INV_CAB_KARDEX.existencia_minima, 
                      dbo.TBL_INV_CAB_KARDEX.existencia_maxima, dbo.TBL_INV_DET_KARDEX.tipo_movimiento, dbo.TBL_INV_DET_KARDEX.fecha_registro, 
                      dbo.TBL_INV_DET_KARDEX.cantidad, dbo.TBL_INV_DET_KARDEX.valor_unitario, dbo.TBL_INV_DET_KARDEX.valor_total, 
                      dbo.TBL_INV_TIPO_MOVIMIENTO.descripcion, dbo.TBL_INV_SUBGRUPO.descripcion AS Nombre_Subgrupo, dbo.TBL_INV_GRUPO.descripcion AS Nombre_Grupo, 
                      dbo.TBL_INV_PRODUCTO.nombre AS Nombre_Producto, dbo.TBL_INV_DET_KARDEX.linea
FROM         dbo.TBL_INV_PRODUCTO INNER JOIN
                      dbo.TBL_INV_GRUPO INNER JOIN
                      dbo.TBL_INV_BODEGA ON dbo.TBL_INV_GRUPO.codigo = dbo.TBL_INV_BODEGA.codigo INNER JOIN
                      dbo.TBL_INV_SUBGRUPO ON dbo.TBL_INV_GRUPO.codigo = dbo.TBL_INV_SUBGRUPO.grupo INNER JOIN
                      dbo.TBL_INV_TIPO_MOVIMIENTO ON dbo.TBL_INV_GRUPO.codigo = dbo.TBL_INV_TIPO_MOVIMIENTO.codigo INNER JOIN
                      dbo.TBL_INV_CAB_KARDEX ON dbo.TBL_INV_BODEGA.codigo = dbo.TBL_INV_CAB_KARDEX.bodega ON 
                      dbo.TBL_INV_PRODUCTO.subgrupo = dbo.TBL_INV_SUBGRUPO.codigo AND dbo.TBL_INV_PRODUCTO.grupo = dbo.TBL_INV_SUBGRUPO.grupo INNER JOIN
                      dbo.TBL_INV_DET_KARDEX ON dbo.TBL_INV_PRODUCTO.codigo = dbo.TBL_INV_DET_KARDEX.producto
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vt_kardex', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[11] 2[7] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_INV_BODEGA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 110
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_CAB_KARDEX"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 125
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_DET_KARDEX"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 125
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_GRUPO"
            Begin Extent = 
               Top = 114
               Left = 38
               Bottom = 203
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_SUBGRUPO"
            Begin Extent = 
               Top = 126
               Left = 274
               Bottom = 230
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_TIPO_MOVIMIENTO"
            Begin Extent = 
               Top = 126
               Left = 510
               Bottom = 215
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_PRODUCTO"
            Begin Extent = 
               Top = 204
               Left = 38
               Bottom = 323
          ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vt_kardex'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vt_kardex', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'     Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2730
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vt_kardex'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vt_kardex', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vt_kardex'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_KARDEX]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[RPT_INV_KARDEX]
(	@producto int, 
	@bodega int,
	@fecha1 datetime,
	@fecha2 datetime
	)
AS
BEGIN

SELECT b.nombre, d.descripcion, e.descripcion,f.nombre,g.descripcion,a.fecha, a.existencia_actual, a.existencia_minima, a.existencia_maxima,
		c.fecha_registro, c.cantidad, c.valor_unitario, c.valor_total 
FROM TBL_INV_CAB_KARDEX a inner join TBL_INV_PRODUCTO b
on a.producto = b.codigo inner join TBL_INV_DET_KARDEX c
on a.producto = c.producto inner join TBL_INV_GRUPO d
on b.grupo = d.codigo inner join TBL_INV_SUBGRUPO e
on b.subgrupo = e.codigo inner join TBL_INV_BODEGA f
on a.bodega = f.codigo inner join TBL_INV_TIPO_MOVIMIENTO g
on c.tipo_movimiento = g.codigo
where (a.producto=@producto and a.bodega = @bodega )and(c.fecha_registro between @fecha1 and @fecha2 )
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_KARDEX_2]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[RPT_INV_KARDEX_2]
(	@producto int, 
	@bodega int
	)
AS
BEGIN

SELECT b.nombre, d.descripcion, e.descripcion,f.nombre,g.descripcion,a.fecha, a.existencia_actual, a.existencia_minima, a.existencia_maxima,
		c.fecha_registro, c.cantidad, c.valor_unitario, c.valor_total 
FROM TBL_INV_CAB_KARDEX a inner join TBL_INV_PRODUCTO b
on a.producto = b.codigo inner join TBL_INV_DET_KARDEX c
on a.producto = c.producto inner join TBL_INV_GRUPO d
on b.grupo = d.codigo inner join TBL_INV_SUBGRUPO e
on b.subgrupo = e.codigo inner join TBL_INV_BODEGA f
on a.bodega = f.codigo inner join TBL_INV_TIPO_MOVIMIENTO g
on c.tipo_movimiento = g.codigo
where (a.producto=@producto and a.bodega = @bodega )
END



' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_MOVIMIENTOS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RPT_INV_MOVIMIENTOS]
as
begin
select a.bodega, c.nombre, a.producto, b.nombre, a.tipo_movimiento, d.descripcion, a.fecha_registro, a.cantidad, a.valor_unitario, a.valor_total
from TBL_INV_DET_KARDEX a inner join TBL_INV_PRODUCTO b
on a.producto = b.codigo inner join TBL_INV_BODEGA c on a.bodega = c.codigo
inner join TBL_INV_TIPO_MOVIMIENTO d on a.tipo_movimiento = d.codigo
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vst_MOVIMIENTOS]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vst_MOVIMIENTOS]
AS
SELECT     a.bodega AS CODIGO_BODEGA, c.nombre, a.producto AS CODIGO_PRODUCTO, b.nombre AS NOMBRE_PRODUCTO, a.tipo_movimiento AS CODIGO_TIPO, 
                      d.descripcion, a.fecha_registro, a.cantidad, a.valor_unitario, a.valor_total
FROM         dbo.TBL_INV_DET_KARDEX AS a INNER JOIN
                      dbo.TBL_INV_PRODUCTO AS b ON a.producto = b.codigo INNER JOIN
                      dbo.TBL_INV_BODEGA AS c ON a.bodega = c.codigo INNER JOIN
                      dbo.TBL_INV_TIPO_MOVIMIENTO AS d ON a.tipo_movimiento = d.codigo
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vst_MOVIMIENTOS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[30] 4[19] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 125
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 110
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 114
               Left = 274
               Bottom = 203
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         Sor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vst_MOVIMIENTOS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'vst_MOVIMIENTOS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'tOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vst_MOVIMIENTOS'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vst_MOVIMIENTOS', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vst_MOVIMIENTOS'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_PRODUCTOSACTIVOS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[RPT_INV_PRODUCTOSACTIVOS]
as
begin
	select a.codigo, a.nombre, b.descripcion as grupo, c.descripcion as subgrupo, d.descripcion as marca, a.presentacion, a.observacion, a.iva, a.estado
	from TBL_INV_PRODUCTO a inner join TBL_INV_GRUPO b
	on a.grupo = b.codigo inner join TBL_INV_SUBGRUPO c on a.subgrupo = c.codigo
	inner join TBL_INV_MARCA d on a.marca = d.codigo
	where estado = 1
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Consulta_Marca]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Consulta_Marca]
	@codigo int
AS
BEGIN
	select a.marca, d.codigo,d.descripcion
	from TBL_INV_PRODUCTO a inner join TBL_INV_MARCA d
	on (a.codigo = @codigo) and (a.marca = d.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_PRODUCTOSINACTIVOS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[RPT_INV_PRODUCTOSINACTIVOS]
as
begin
	select a.codigo, a.nombre, b.descripcion as grupo, c.descripcion as subgrupo, d.descripcion as marca, a.presentacion, a.observacion, a.iva
	from TBL_INV_PRODUCTO a inner join TBL_INV_GRUPO b
	on a.grupo = b.codigo inner join TBL_INV_SUBGRUPO c on a.subgrupo = c.codigo
	inner join TBL_INV_MARCA d on a.marca = d.codigo
	where estado = 0
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_PRODUCTOS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_RPT_PRODUCTOS]
AS
BEGIN
	select a.codigo,a.nombre,b.descripcion as grupo,c.descripcion as subgrupo,d.descripcion as marca,a.presentacion,a.observacion, a.iva, a.estado
	from TBL_INV_PRODUCTO a inner join TBL_INV_GRUPO b 
	on a.grupo=b.codigo inner join TBL_INV_SUBGRUPO c 
	on a.subgrupo=c.codigo inner join TBL_INV_MARCA d
	on a.marca = d.codigo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_PRODUCTOSXGRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[RPT_INV_PRODUCTOSXGRUPO]
(
	@grupo nvarchar(30),
	@subgrupo nvarchar(30)

)
as
begin
select a.descripcion as grupo,d.descripcion as subgrupo, b.nombre as producto, c.descripcion as marca, b.presentacion, b.iva
from TBL_INV_GRUPO a inner join TBL_INV_PRODUCTO b
on a.codigo = b.grupo inner join TBL_INV_MARCA c
on b.marca = c.codigo inner join TBL_INV_SUBGRUPO d
on b.subgrupo = d.codigo
where a.descripcion = @grupo and d.descripcion = @subgrupo
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ConMarcaGeneral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_ConMarcaGeneral]
	@codigo int
AS
BEGIN
	select descripcion from TBL_INV_MARCA 
	where codigo=@codigo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ConMarcaDescripcion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ConMarcaDescripcion]
(
		@descripcion nvarchar(50)
)
AS
	SELECT descripcion FROM TBL_INV_MARCA
	WHERE descripcion = @descripcion' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngMarca]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_IngMarca]
(
		@descripcion nvarchar(50)
)
AS
		INSERT TBL_INV_MARCA (descripcion)
			VALUES(@descripcion)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModMarca]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModMarca]
(
		@codigo int,
		@descripcion nvarchar(50)
)
AS

	IF EXISTS (SELECT 1 FROM TBL_INV_MARCA 
				WHERE codigo = @codigo)
		UPDATE TBL_INV_MARCA
		SET descripcion = @descripcion
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_EliMarca]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_EliMarca]
(
		@codigo int
)
AS
	IF EXISTS (SELECT 1 FROM TBL_INV_MARCA 
				WHERE codigo = @codigo)
		DELETE TBL_INV_MARCA
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_MarcaxProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_MarcaxProducto]
	@codigo int
AS
BEGIN
	select d.marca, a.codigo,a.descripcion
	from TBL_INV_PRODUCTO d inner join TBL_INV_MARCA a
	on (a.codigo = @codigo) and (d.marca = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_Producto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_Producto]
	@codigo int
AS
BEGIN
	select a.nombre, a.grupo,b.codigo, b.descripcion, a.subgrupo, a.marca, a.presentacion, a.observacion, a.iva, a.estado 
	from TBL_INV_PRODUCTO a inner join TBL_INV_GRUPO b
	on (a.codigo = @codigo) and (a.grupo = b.codigo)
	select a.subgrupo, c.codigo,c.descripcion as NombreSubgrupo
	from TBL_INV_PRODUCTO a inner join TBL_INV_SUBGRUPO c 
	on ((a.codigo = @codigo) and (a.subgrupo = c.codigo))
	select a.marca, d.codigo,d.descripcion as NombreMarca
	from TBL_INV_PRODUCTO a inner join TBL_INV_MARCA d
	on (a.codigo = @codigo) and (a.marca = d.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngDireccion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_IngDireccion]
(
		@bodega int,
		@zona int,
		@calle_principal nvarchar(30),
		@calle_transversal nvarchar(30),
		@descripcion_amplia nvarchar(50)
)
AS
		INSERT TBL_INV_DIRECCION (bodega, zona, calle_principal, calle_transversal, descripcion_amplia)
			VALUES(@bodega, @zona, @calle_principal, @calle_transversal, @descripcion_amplia)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModDireccion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModDireccion]
(
		@numero int,
		@bodega int,
		@zona int,
		@calle_principal nvarchar(30),
		@calle_transversal nvarchar(30),
		@descripcion_amplia nvarchar(50)
)
AS

	IF EXISTS (SELECT 1 FROM TBL_INV_DIRECCION 
				WHERE numero = @numero)
		UPDATE TBL_INV_DIRECCION
		SET bodega = @bodega,
			zona = @zona,
			calle_principal = @calle_principal,
			calle_transversal = @calle_transversal,
			descripcion_amplia = @descripcion_amplia			
		WHERE numero = @numero
	ELSE
		RAISERROR(''Parametro no existe'',16,1)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ConDireccionBodega]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_ConDireccionBodega]
(
		@bodega int
)
AS
	SELECT numero, zona, calle_principal, calle_transversal, descripcion_amplia FROM TBL_INV_DIRECCION
	WHERE bodega = @bodega
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_ZonaCiudadxDireccion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_ZonaCiudadxDireccion]
	@codigo int
AS
BEGIN
	select d.zona, a.codigo,a.ciudad,a.nombre
	from TBL_INV_DIRECCION d inner join TBL_INV_ZONA a
	on (a.codigo = @codigo) and (d.zona = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_CabKardex]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_CabKardex] 
@bodega as int, 
@producto as int
AS
BEGIN
	select existencia_actual, existencia_minima, existencia_maxima, responsable, linea, tipo_movimiento, fecha_registro, cantidad, valor_unitario
	from TBL_INV_CAB_KARDEX C, TBL_INV_DET_KARDEX D, TBL_INV_PRODUCTO P, TBL_INV_BODEGA B
	WHERE d.bodega=c.bodega and d.producto=c.producto and p.codigo=c.producto and b.codigo=c.bodega
	and c.producto=@producto and c.bodega=@bodega


END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_Zona]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_Zona]
	@codigo int
AS
BEGIN
	select Nombre from TBL_INV_ZONA 
	where codigo=@codigo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_InCabKardex]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE Procedure [dbo].[SP_InCabKardex]
(
		@bodega int,
		@producto int,
		@fecha datetime,
		@existencia_actual int ,
		@existencia_minima int,
		@existencia_maxima int,
		@responsable int
	
)
AS
		INSERT into TBL_INV_CAB_KARDEX
			VALUES(@bodega,@producto,@fecha,@existencia_actual,@existencia_minima,@existencia_maxima,@responsable)





' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RPT_INV_PRODUCTOXBODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RPT_INV_PRODUCTOXBODEGA](
	@nombre varchar(30)
)
as
begin
SELECT     dbo.TBL_INV_PRODUCTO.codigo as Codigo_Producto,dbo.TBL_INV_PRODUCTO.nombre as Nombre_Producto, dbo.TBL_INV_BODEGA.codigo AS Codigo_Bodega,dbo.TBL_INV_BODEGA.nombre AS Nombre_Bodega
FROM       dbo.TBL_INV_CAB_KARDEX INNER JOIN
           dbo.TBL_INV_PRODUCTO ON dbo.TBL_INV_CAB_KARDEX.producto = dbo.TBL_INV_PRODUCTO.codigo INNER JOIN
           dbo.TBL_INV_BODEGA ON dbo.TBL_INV_CAB_KARDEX.bodega = dbo.TBL_INV_BODEGA.codigo
	where dbo.TBL_INV_BODEGA.nombre = @nombre
end' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vst_ProductoxBodega]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vst_ProductoxBodega]
AS
SELECT     dbo.TBL_INV_PRODUCTO.codigo AS Codigo_Producto, dbo.TBL_INV_PRODUCTO.nombre AS Nombre_Producto, dbo.TBL_INV_BODEGA.codigo AS Codigo_Bodega, 
                      dbo.TBL_INV_BODEGA.nombre AS Nombre_Bodega
FROM         dbo.TBL_INV_CAB_KARDEX INNER JOIN
                      dbo.TBL_INV_PRODUCTO ON dbo.TBL_INV_CAB_KARDEX.producto = dbo.TBL_INV_PRODUCTO.codigo INNER JOIN
                      dbo.TBL_INV_BODEGA ON dbo.TBL_INV_CAB_KARDEX.bodega = dbo.TBL_INV_BODEGA.codigo
' 
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vst_ProductoxBodega', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_INV_CAB_KARDEX"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 236
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_PRODUCTO"
            Begin Extent = 
               Top = 6
               Left = 274
               Bottom = 125
               Right = 472
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_INV_BODEGA"
            Begin Extent = 
               Top = 6
               Left = 510
               Bottom = 110
               Right = 708
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vst_ProductoxBodega'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vst_ProductoxBodega', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vst_ProductoxBodega'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_ING_DET_ORDEN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[INV_ING_DET_ORDEN]
@Número int, @Bodega int, @Línea int, @Producto int, @Cantidad int, @estado bit
AS
BEGIN
	Insert into TBL_INV_DET_ORDEN_PEDIDO values (@Número,@Bodega, @Línea, @Producto, @Cantidad,@estado)
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Consulta_Subgrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Consulta_Subgrupo]
	@codigo int
AS
BEGIN
	select a.subgrupo, c.codigo,c.descripcion
	from TBL_INV_PRODUCTO a inner join TBL_INV_SUBGRUPO c 
	on ((a.codigo = @codigo) and (a.subgrupo = c.codigo))
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_CodiProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_CodiProducto]
	@codigo int
AS
BEGIN
	select p.codigo, p.nombre,p.grupo, P.subgrupo, g.descripcion as ''descripcionGrupo'',s.descripcion as ''DescripcionSubGrupo''
	from 
	TBL_INV_PRODUCTO as p,
	TBL_INV_GRUPO as g,
	TBL_INV_SUBGRUPO as s
	where 
	p.grupo = g.codigo and
	s.grupo = g.codigo and
	p.subGrupo = s.codigo and
	p.codigo=@codigo
	
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_SubgrupoxProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_SubgrupoxProducto]
	@codigo int
AS
BEGIN
	select d.subgrupo, a.codigo,a.descripcion
	from TBL_INV_PRODUCTO d inner join TBL_INV_SUBGRUPO a
	on (a.codigo = @codigo) and (d.subgrupo = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_EliSubgrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_EliSubgrupo]
(
		@codigo int
)
AS
	IF EXISTS (SELECT 1 FROM TBL_INV_SUBGRUPO
				WHERE codigo = @codigo)
		DELETE TBL_INV_SUBGRUPO
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_Subgrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_Subgrupo]
	@Grupo int
AS
BEGIN
	select descripcion from TBL_INV_SUBGRUPO 
	where grupo=@Grupo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngSubGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_IngSubGrupo]
(
		@Grupo	int,
		@Descripción nvarchar(50)
)
AS
		INSERT TBL_INV_SUBGRUPO (grupo,descripcion)
			VALUES(@Grupo,@Descripción)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_GrupoxProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_GrupoxProducto]
	@codigo int
AS
BEGIN
	select d.grupo, a.codigo,a.descripcion
	from TBL_INV_PRODUCTO d inner join TBL_INV_GRUPO a
	on (a.codigo = @codigo) and (d.grupo = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE Procedure [dbo].[SP_IngProducto]
(	
	@nombre nvarchar(30),
	@grupo int,
	@subgrupo int,
	@marca int,
	@presentacion nvarchar(30),
	@observacion nvarchar(40),
	@iva nvarchar(5),
	@estado int
)
AS
		INSERT TBL_INV_PRODUCTO (nombre, grupo, subgrupo, marca, presentacion,observacion, iva, estado)
			VALUES(@nombre, @grupo, @subgrupo, @marca, @presentacion, @observacion, @iva, @estado)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_ModProducto]
(	
	@codigo int,
	@nombre nvarchar(30),
	@grupo int,
	@subgrupo int,
	@marca int,
	@presentacion nvarchar(30),
	@observacion nvarchar(40),
	@iva nvarchar(5),
	@estado int
)
AS
		UPDATE TBL_INV_PRODUCTO 
		SET nombre = @nombre, 
			grupo = @grupo, 
			subgrupo = @subgrupo,
			marca = @marca,
			presentacion = @presentacion,
			observacion = @observacion,
			iva = @iva,
			estado = @estado
where codigo = @codigo' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModEstadoProductoNombre]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create Procedure [dbo].[SP_ModEstadoProductoNombre]
(	
	@nombre nvarchar(30),
	@estado int
)
AS
		UPDATE TBL_INV_PRODUCTO 
		SET estado = @estado
where nombre = @nombre' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_CONSULTA_PRODUCTOACTIVO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_CONSULTA_PRODUCTOACTIVO]
AS
BEGIN
	select nombre, grupo, subgrupo, marca, presentacion, observacion, iva, estado from TBL_INV_PRODUCTO
	where estado = 1
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModEstadoProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create Procedure [dbo].[SP_ModEstadoProducto]
(	
	@codigo int,
	@estado int
)
AS
		UPDATE TBL_INV_PRODUCTO 
		SET estado = @estado
where codigo = @codigo' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_NombreProducto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_NombreProducto]
	@nombre nvarchar(30)
AS
BEGIN
	select nombre, grupo,subgrupo,marca,presentacion,observacion,iva,estado 
	from TBL_INV_PRODUCTO
	where (nombre = @nombre)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_CON_PRODUCTO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_CON_PRODUCTO]
	@codigo int
AS
BEGIN
	select nombre, grupo, subgrupo, marca, presentacion, observacion, iva, estado from TBL_INV_PRODUCTO
	where codigo=@codigo and estado=1
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_PRODUCTO_GENERAL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[INV_RPT_PRODUCTO_GENERAL]
	@estado int
AS
BEGIN
	select * 
	from TBL_INV_PRODUCTO
	where estado = @estado
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_ESPECÍFICO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_ESPECÍFICO]
@Producto int, @Bodega int, @Grupo int 
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Producto=@Producto
	AND Inv_Cab_Kardex.Bodega=@Bodega AND Inv_Producto.Grupo=@Grupo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_BODEGA_Y_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_BODEGA_Y_GRUPO]
@Bodega int, @Grupo int 
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Bodega=@Bodega
	and Inv_Producto.Grupo=@Grupo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_RPT_BAJOMINIMO]
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO]
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_BODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_BODEGA]
@Bodega int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Bodega=@Bodega
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_GRUPO]
@Grupo int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Producto.Grupo=@Grupo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_PRODUCTO_Y_BODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_PRODUCTO_Y_BODEGA]
@Producto int, @Bodega int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Producto=@Producto AND Inv_Cab_Kardex.Bodega=@Bodega
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_PRODUCTO_Y_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_PRODUCTO_Y_GRUPO]
@Producto int, @Grupo int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Producto=@Producto AND Inv_Producto.Grupo=@Grupo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO_Y_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO_Y_GRUPO]
@Producto int, @Grupo int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Producto=@Producto AND Inv_Producto.Grupo=@Grupo
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_BODEGA_Y_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_BODEGA_Y_GRUPO]
@Bodega int, @Grupo int 
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Bodega=@Bodega
	and Inv_Producto.Grupo=@Grupo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_BODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_BODEGA]
@Bodega int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Bodega=@Bodega
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_BAJOMINIMO_PRODUCTO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create PROCEDURE [dbo].[INV_RPT_BAJOMINIMO_PRODUCTO]
@Producto int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Mínima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual<Existencia_Mínima AND Inv_Cab_Kardex.Producto=@Producto
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO]
@Producto int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Producto=@Producto
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO_Y_BODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_PRODUCTO_Y_BODEGA]
@Producto int, @Bodega int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Producto=@Producto AND Inv_Cab_Kardex.Bodega=@Bodega
END

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_ESPECÍFICO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_ESPECÍFICO]
@Producto int, @Bodega int, @Grupo int 
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Cab_Kardex.Producto=@Producto
	AND Inv_Cab_Kardex.Bodega=@Bodega AND Inv_Producto.Grupo=@Grupo
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INV_RPT_SOBREMÁXIMO_GRUPO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create PROCEDURE [dbo].[INV_RPT_SOBREMÁXIMO_GRUPO]
@Grupo int
AS
BEGIN
	select Inv_Cab_Kardex.Producto, Inv_Producto.Descripción, Inv_Grupo.Descripción, Nombre, Existencia_Actual, Existencia_Máxima 
	from Inv_Producto, Inv_Cab_Kardex, Inv_Bodega, Inv_Grupo
	where Inv_Producto.Código=Inv_Cab_Kardex.Producto AND Inv_Bodega.Código=Inv_Cab_Kardex.Bodega AND
	Inv_Producto.Grupo=Inv_Grupo.Código AND Existencia_Actual>Existencia_Máxima AND Inv_Producto.Grupo=@Grupo
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_Grupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Cons_Grupo]
	@Código int
AS
BEGIN
	select descripcion from TBL_INV_GRUPO 
	where codigo=@Código
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModGrupo]
(
		@codigo int,
		@descripcion nvarchar(50)
)
AS

	IF EXISTS (SELECT 1 FROM TBL_INV_GRUPO 
				WHERE codigo = @codigo)
		UPDATE TBL_INV_GRUPO
		SET descripcion = @descripcion
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_EliGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_EliGrupo]
(
		@codigo int
)
AS
	IF EXISTS (SELECT 1 FROM Inv_Grupo 
				WHERE Código = @codigo)
		DELETE Inv_Grupo
		WHERE Código = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngGrupo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_IngGrupo]
(	
	@descripcion nvarchar(50)
)
AS
		INSERT TBL_INV_GRUPO (descripcion)
			VALUES(@descripcion)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Cons_BodegaxKardex]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP_Cons_BodegaxKardex]
	@codigo int
AS
BEGIN
	select d.bodega, a.codigo,a.nombre
	from TBL_INV_CAB_KARDEX d inner join TBL_INV_BODEGA a
	on (a.codigo = @codigo) and (d.bodega = a.codigo)
END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_IngBodega]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_IngBodega]
(
		@nombre nvarchar(30)
)
AS
		INSERT TBL_INV_BODEGA (nombre)
			VALUES(@nombre)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ModBodega]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[SP_ModBodega]
(
		@codigo int,
		@nombre nvarchar(30)
)
AS

	IF EXISTS (SELECT 1 FROM TBL_INV_BODEGA 
				WHERE codigo = @codigo)
		UPDATE TBL_INV_BODEGA
		SET nombre = @nombre
		WHERE codigo = @codigo
	ELSE
		RAISERROR(''Parametro no existe'',16,1)' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_ConsKBodega]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE Procedure [dbo].[SP_ConsKBodega]
(
		@codigo int
)
AS
	SELECT codigo, nombre FROM TBL_INV_BODEGA
	WHERE codigo = @codigo

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CON_BODEGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CON_BODEGA]
	@codigo int
AS
BEGIN
	select Nombre from TBL_INV_BODEGA 
	where codigo=@codigo
END
' 
END
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Kardex_Cant]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_KARDEX]'))
ALTER TABLE [dbo].[TBL_INV_DET_KARDEX]  WITH CHECK ADD  CONSTRAINT [CK_Kardex_Cant] CHECK  (([cantidad]>=(0)))
GO
ALTER TABLE [dbo].[TBL_INV_DET_KARDEX] CHECK CONSTRAINT [CK_Kardex_Cant]
GO
IF NOT EXISTS (SELECT * FROM sys.check_constraints WHERE object_id = OBJECT_ID(N'[dbo].[CK_Kardex_ValorUnit]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_KARDEX]'))
ALTER TABLE [dbo].[TBL_INV_DET_KARDEX]  WITH CHECK ADD  CONSTRAINT [CK_Kardex_ValorUnit] CHECK  (([valor_unitario]>=(0)))
GO
ALTER TABLE [dbo].[TBL_INV_DET_KARDEX] CHECK CONSTRAINT [CK_Kardex_ValorUnit]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Zona_Ciudad]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_ZONA]'))
ALTER TABLE [dbo].[TBL_INV_ZONA]  WITH CHECK ADD  CONSTRAINT [FK_Zona_Ciudad] FOREIGN KEY([ciudad])
REFERENCES [dbo].[TBL_INV_CIUDAD] ([codigo])
GO
ALTER TABLE [dbo].[TBL_INV_ZONA] CHECK CONSTRAINT [FK_Zona_Ciudad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Inv_Producto_Marca]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_PRODUCTO]'))
ALTER TABLE [dbo].[TBL_INV_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Producto_Marca] FOREIGN KEY([marca])
REFERENCES [dbo].[TBL_INV_MARCA] ([codigo])
GO
ALTER TABLE [dbo].[TBL_INV_PRODUCTO] CHECK CONSTRAINT [FK_Inv_Producto_Marca]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_INV_PRODUCTO_TBL_INV_SUBGRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_PRODUCTO]'))
ALTER TABLE [dbo].[TBL_INV_PRODUCTO]  WITH CHECK ADD  CONSTRAINT [FK_TBL_INV_PRODUCTO_TBL_INV_SUBGRUPO] FOREIGN KEY([subgrupo], [grupo])
REFERENCES [dbo].[TBL_INV_SUBGRUPO] ([codigo], [grupo])
GO
ALTER TABLE [dbo].[TBL_INV_PRODUCTO] CHECK CONSTRAINT [FK_TBL_INV_PRODUCTO_TBL_INV_SUBGRUPO]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dirección_Bodega]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DIRECCION]'))
ALTER TABLE [dbo].[TBL_INV_DIRECCION]  WITH NOCHECK ADD  CONSTRAINT [FK_Dirección_Bodega] FOREIGN KEY([bodega])
REFERENCES [dbo].[TBL_INV_BODEGA] ([codigo])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[TBL_INV_DIRECCION] NOCHECK CONSTRAINT [FK_Dirección_Bodega]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Dirección_Zona]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DIRECCION]'))
ALTER TABLE [dbo].[TBL_INV_DIRECCION]  WITH NOCHECK ADD  CONSTRAINT [FK_Dirección_Zona] FOREIGN KEY([zona])
REFERENCES [dbo].[TBL_INV_ZONA] ([codigo])
ON UPDATE SET DEFAULT
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[TBL_INV_DIRECCION] NOCHECK CONSTRAINT [FK_Dirección_Zona]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Det_Orden_Producto]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_ORDEN_PEDIDO]'))
ALTER TABLE [dbo].[TBL_INV_DET_ORDEN_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_Det_Orden_Producto] FOREIGN KEY([producto])
REFERENCES [dbo].[TBL_INV_PRODUCTO] ([codigo])
GO
ALTER TABLE [dbo].[TBL_INV_DET_ORDEN_PEDIDO] CHECK CONSTRAINT [FK_Det_Orden_Producto]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Inv_Det_Orden_Pedido_Inv_Cab_Orden_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_DET_ORDEN_PEDIDO]'))
ALTER TABLE [dbo].[TBL_INV_DET_ORDEN_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Det_Orden_Pedido_Inv_Cab_Orden_Pedido] FOREIGN KEY([numero], [bodega])
REFERENCES [dbo].[TBL_INV_CAB_ORDEN_PEDIDO] ([numero], [bodega])
GO
ALTER TABLE [dbo].[TBL_INV_DET_ORDEN_PEDIDO] CHECK CONSTRAINT [FK_Inv_Det_Orden_Pedido_Inv_Cab_Orden_Pedido]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TBL_INV_SUBGRUPO_TBL_INV_GRUPO]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_SUBGRUPO]'))
ALTER TABLE [dbo].[TBL_INV_SUBGRUPO]  WITH CHECK ADD  CONSTRAINT [FK_TBL_INV_SUBGRUPO_TBL_INV_GRUPO] FOREIGN KEY([grupo])
REFERENCES [dbo].[TBL_INV_GRUPO] ([codigo])
GO
ALTER TABLE [dbo].[TBL_INV_SUBGRUPO] CHECK CONSTRAINT [FK_TBL_INV_SUBGRUPO_TBL_INV_GRUPO]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Inv_Bodega]') AND parent_object_id = OBJECT_ID(N'[dbo].[TBL_INV_CAB_ORDEN_PEDIDO]'))
ALTER TABLE [dbo].[TBL_INV_CAB_ORDEN_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_Inv_Bodega] FOREIGN KEY([bodega])
REFERENCES [dbo].[TBL_INV_BODEGA] ([codigo])
GO
ALTER TABLE [dbo].[TBL_INV_CAB_ORDEN_PEDIDO] CHECK CONSTRAINT [FK_Inv_Bodega]
