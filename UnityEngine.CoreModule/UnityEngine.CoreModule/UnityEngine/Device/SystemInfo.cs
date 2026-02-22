using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine.Device
{
	// Token: 0x020002CC RID: 716
	public static class SystemInfo
	{
		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x000145A9 File Offset: 0x000127A9
		public static float batteryLevel
		{
			get
			{
				return SystemInfo.batteryLevel;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000145B0 File Offset: 0x000127B0
		public static BatteryStatus batteryStatus
		{
			get
			{
				return SystemInfo.batteryStatus;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000145B7 File Offset: 0x000127B7
		public static string operatingSystem
		{
			get
			{
				return SystemInfo.operatingSystem;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000145BE File Offset: 0x000127BE
		public static OperatingSystemFamily operatingSystemFamily
		{
			get
			{
				return SystemInfo.operatingSystemFamily;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x000145C5 File Offset: 0x000127C5
		public static string processorType
		{
			get
			{
				return SystemInfo.processorType;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000145CC File Offset: 0x000127CC
		public static int processorFrequency
		{
			get
			{
				return SystemInfo.processorFrequency;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000145D3 File Offset: 0x000127D3
		public static int processorCount
		{
			get
			{
				return SystemInfo.processorCount;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000145DA File Offset: 0x000127DA
		public static int systemMemorySize
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000145E1 File Offset: 0x000127E1
		public static string deviceUniqueIdentifier
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000145E8 File Offset: 0x000127E8
		public static string deviceName
		{
			get
			{
				return SystemInfo.deviceName;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000145EF File Offset: 0x000127EF
		public static string deviceModel
		{
			get
			{
				return SystemInfo.deviceModel;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x000145F6 File Offset: 0x000127F6
		public static bool supportsAccelerometer
		{
			get
			{
				return SystemInfo.supportsAccelerometer;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000145FD File Offset: 0x000127FD
		public static bool supportsGyroscope
		{
			get
			{
				return SystemInfo.supportsGyroscope;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00014604 File Offset: 0x00012804
		public static bool supportsLocationService
		{
			get
			{
				return SystemInfo.supportsLocationService;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0001460B File Offset: 0x0001280B
		public static bool supportsVibration
		{
			get
			{
				return SystemInfo.supportsVibration;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00014612 File Offset: 0x00012812
		public static bool supportsAudio
		{
			get
			{
				return SystemInfo.supportsAudio;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00014619 File Offset: 0x00012819
		public static DeviceType deviceType
		{
			get
			{
				return SystemInfo.deviceType;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00014620 File Offset: 0x00012820
		public static int graphicsMemorySize
		{
			get
			{
				return SystemInfo.graphicsMemorySize;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00014627 File Offset: 0x00012827
		public static string graphicsDeviceName
		{
			get
			{
				return SystemInfo.graphicsDeviceName;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x0001462E File Offset: 0x0001282E
		public static string graphicsDeviceVendor
		{
			get
			{
				return SystemInfo.graphicsDeviceVendor;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00014635 File Offset: 0x00012835
		public static int graphicsDeviceID
		{
			get
			{
				return SystemInfo.graphicsDeviceID;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0001463C File Offset: 0x0001283C
		public static int graphicsDeviceVendorID
		{
			get
			{
				return SystemInfo.graphicsDeviceVendorID;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00014643 File Offset: 0x00012843
		public static UnityEngine.Rendering.GraphicsDeviceType graphicsDeviceType
		{
			get
			{
				return SystemInfo.graphicsDeviceType;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0001464A File Offset: 0x0001284A
		public static bool graphicsUVStartsAtTop
		{
			get
			{
				return SystemInfo.graphicsUVStartsAtTop;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x00014651 File Offset: 0x00012851
		public static string graphicsDeviceVersion
		{
			get
			{
				return SystemInfo.graphicsDeviceVersion;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x00014658 File Offset: 0x00012858
		public static int graphicsShaderLevel
		{
			get
			{
				return SystemInfo.graphicsShaderLevel;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0001465F File Offset: 0x0001285F
		public static bool graphicsMultiThreaded
		{
			get
			{
				return SystemInfo.graphicsMultiThreaded;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x00014666 File Offset: 0x00012866
		public static UnityEngine.Rendering.RenderingThreadingMode renderingThreadingMode
		{
			get
			{
				return SystemInfo.renderingThreadingMode;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x0001466D File Offset: 0x0001286D
		public static bool hasHiddenSurfaceRemovalOnGPU
		{
			get
			{
				return SystemInfo.hasHiddenSurfaceRemovalOnGPU;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00014674 File Offset: 0x00012874
		public static bool hasDynamicUniformArrayIndexingInFragmentShaders
		{
			get
			{
				return SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0001467B File Offset: 0x0001287B
		public static bool supportsShadows
		{
			get
			{
				return SystemInfo.supportsShadows;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00014682 File Offset: 0x00012882
		public static bool supportsRawShadowDepthSampling
		{
			get
			{
				return SystemInfo.supportsRawShadowDepthSampling;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00014689 File Offset: 0x00012889
		public static bool supportsMotionVectors
		{
			get
			{
				return SystemInfo.supportsMotionVectors;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00014690 File Offset: 0x00012890
		public static bool supports3DTextures
		{
			get
			{
				return SystemInfo.supports3DTextures;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00014697 File Offset: 0x00012897
		public static bool supportsCompressed3DTextures
		{
			get
			{
				return SystemInfo.supportsCompressed3DTextures;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0001469E File Offset: 0x0001289E
		public static bool supports2DArrayTextures
		{
			get
			{
				return SystemInfo.supports2DArrayTextures;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000146A5 File Offset: 0x000128A5
		public static bool supports3DRenderTextures
		{
			get
			{
				return SystemInfo.supports3DRenderTextures;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000146AC File Offset: 0x000128AC
		public static bool supportsCubemapArrayTextures
		{
			get
			{
				return SystemInfo.supportsCubemapArrayTextures;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000146B3 File Offset: 0x000128B3
		public static UnityEngine.Rendering.CopyTextureSupport copyTextureSupport
		{
			get
			{
				return SystemInfo.copyTextureSupport;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000146BA File Offset: 0x000128BA
		public static bool supportsComputeShaders
		{
			get
			{
				return SystemInfo.supportsComputeShaders;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000146C1 File Offset: 0x000128C1
		public static bool supportsGeometryShaders
		{
			get
			{
				return SystemInfo.supportsGeometryShaders;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000146C8 File Offset: 0x000128C8
		public static bool supportsTessellationShaders
		{
			get
			{
				return SystemInfo.supportsTessellationShaders;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000146CF File Offset: 0x000128CF
		public static bool supportsRenderTargetArrayIndexFromVertexShader
		{
			get
			{
				return SystemInfo.supportsRenderTargetArrayIndexFromVertexShader;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x000146D6 File Offset: 0x000128D6
		public static bool supportsInstancing
		{
			get
			{
				return SystemInfo.supportsInstancing;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000146DD File Offset: 0x000128DD
		public static bool supportsHardwareQuadTopology
		{
			get
			{
				return SystemInfo.supportsHardwareQuadTopology;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x000146E4 File Offset: 0x000128E4
		public static bool supports32bitsIndexBuffer
		{
			get
			{
				return SystemInfo.supports32bitsIndexBuffer;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000146EB File Offset: 0x000128EB
		public static bool supportsSparseTextures
		{
			get
			{
				return SystemInfo.supportsSparseTextures;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x000146F2 File Offset: 0x000128F2
		public static int supportedRenderTargetCount
		{
			get
			{
				return SystemInfo.supportedRenderTargetCount;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000146F9 File Offset: 0x000128F9
		public static bool supportsSeparatedRenderTargetsBlend
		{
			get
			{
				return SystemInfo.supportsSeparatedRenderTargetsBlend;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00014700 File Offset: 0x00012900
		public static int supportedRandomWriteTargetCount
		{
			get
			{
				return SystemInfo.supportedRandomWriteTargetCount;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00014707 File Offset: 0x00012907
		public static int supportsMultisampledTextures
		{
			get
			{
				return SystemInfo.supportsMultisampledTextures;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0001470E File Offset: 0x0001290E
		public static bool supportsMultisampled2DArrayTextures
		{
			get
			{
				return SystemInfo.supportsMultisampled2DArrayTextures;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00014715 File Offset: 0x00012915
		public static bool supportsMultisampleAutoResolve
		{
			get
			{
				return SystemInfo.supportsMultisampleAutoResolve;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0001471C File Offset: 0x0001291C
		public static int supportsTextureWrapMirrorOnce
		{
			get
			{
				return SystemInfo.supportsTextureWrapMirrorOnce;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00014723 File Offset: 0x00012923
		public static bool usesReversedZBuffer
		{
			get
			{
				return SystemInfo.usesReversedZBuffer;
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0006A7A4 File Offset: 0x000689A4
		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRenderTextureFormat(format);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0006A7BC File Offset: 0x000689BC
		public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0006A7D4 File Offset: 0x000689D4
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return SystemInfo.SupportsTextureFormat(format);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0006A7EC File Offset: 0x000689EC
		public static bool SupportsVertexAttributeFormat(UnityEngine.Rendering.VertexAttributeFormat format, int dimension)
		{
			return SystemInfo.SupportsVertexAttributeFormat(format, dimension);
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0001472A File Offset: 0x0001292A
		public static NPOTSupport npotSupport
		{
			get
			{
				return SystemInfo.npotSupport;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00014731 File Offset: 0x00012931
		public static int maxTextureSize
		{
			get
			{
				return SystemInfo.maxTextureSize;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00014738 File Offset: 0x00012938
		public static int maxCubemapSize
		{
			get
			{
				return SystemInfo.maxCubemapSize;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0001473F File Offset: 0x0001293F
		public static int maxComputeBufferInputsVertex
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsVertex;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00014746 File Offset: 0x00012946
		public static int maxComputeBufferInputsFragment
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsFragment;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0001474D File Offset: 0x0001294D
		public static int maxComputeBufferInputsGeometry
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsGeometry;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00014754 File Offset: 0x00012954
		public static int maxComputeBufferInputsDomain
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsDomain;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0001475B File Offset: 0x0001295B
		public static int maxComputeBufferInputsHull
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsHull;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00014762 File Offset: 0x00012962
		public static int maxComputeBufferInputsCompute
		{
			get
			{
				return SystemInfo.maxComputeBufferInputsCompute;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00014769 File Offset: 0x00012969
		public static int maxComputeWorkGroupSize
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSize;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00014770 File Offset: 0x00012970
		public static int maxComputeWorkGroupSizeX
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeX;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00014777 File Offset: 0x00012977
		public static int maxComputeWorkGroupSizeY
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeY;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x0001477E File Offset: 0x0001297E
		public static int maxComputeWorkGroupSizeZ
		{
			get
			{
				return SystemInfo.maxComputeWorkGroupSizeZ;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00014785 File Offset: 0x00012985
		public static bool supportsAsyncCompute
		{
			get
			{
				return SystemInfo.supportsAsyncCompute;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x0001478C File Offset: 0x0001298C
		public static bool supportsGpuRecorder
		{
			get
			{
				return SystemInfo.supportsGpuRecorder;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x00014793 File Offset: 0x00012993
		public static bool supportsGraphicsFence
		{
			get
			{
				return SystemInfo.supportsGraphicsFence;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x0001479A File Offset: 0x0001299A
		public static bool supportsAsyncGPUReadback
		{
			get
			{
				return SystemInfo.supportsAsyncGPUReadback;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000147A1 File Offset: 0x000129A1
		public static bool supportsRayTracing
		{
			get
			{
				return SystemInfo.supportsRayTracing;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000147A8 File Offset: 0x000129A8
		public static bool supportsSetConstantBuffer
		{
			get
			{
				return SystemInfo.supportsSetConstantBuffer;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000147AF File Offset: 0x000129AF
		public static int constantBufferOffsetAlignment
		{
			get
			{
				return SystemInfo.constantBufferOffsetAlignment;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000147B6 File Offset: 0x000129B6
		public static bool hasMipMaxLevel
		{
			get
			{
				return SystemInfo.hasMipMaxLevel;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000147BD File Offset: 0x000129BD
		public static bool supportsMipStreaming
		{
			get
			{
				return SystemInfo.supportsMipStreaming;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000147C4 File Offset: 0x000129C4
		public static bool usesLoadStoreActions
		{
			get
			{
				return SystemInfo.usesLoadStoreActions;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000147CB File Offset: 0x000129CB
		public static HDRDisplaySupportFlags hdrDisplaySupportFlags
		{
			get
			{
				return SystemInfo.hdrDisplaySupportFlags;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000147D2 File Offset: 0x000129D2
		public static bool supportsConservativeRaster
		{
			get
			{
				return SystemInfo.supportsConservativeRaster;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000147D9 File Offset: 0x000129D9
		public static bool supportsMultiview
		{
			get
			{
				return SystemInfo.supportsMultiview;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000147E0 File Offset: 0x000129E0
		public static bool supportsStoreAndResolveAction
		{
			get
			{
				return SystemInfo.supportsStoreAndResolveAction;
			}
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0006A808 File Offset: 0x00068A08
		public static bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.IsFormatSupported(format, usage);
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0006A824 File Offset: 0x00068A24
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			return SystemInfo.GetCompatibleFormat(format, usage);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0006A840 File Offset: 0x00068A40
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			return SystemInfo.GetGraphicsFormat(format);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0006A858 File Offset: 0x00068A58
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0006A870 File Offset: 0x00068A70
		public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
		{
			return SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
		}

		// Token: 0x04001BD4 RID: 7124
		public const string unsupportedIdentifier = "n/a";
	}
}
