using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000077 RID: 119
	[StructLayout(2)]
	public struct RenderTextureDescriptor
	{
		// Token: 0x06000BF8 RID: 3064 RVA: 0x000332B8 File Offset: 0x000314B8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureDescriptor()
		{
			Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTextureDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr);
			RenderTextureDescriptor.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<width>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<height>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__msaaSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<msaaSamples>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__volumeDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<volumeDepth>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__mipCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<mipCount>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__graphicsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_graphicsFormat");
			RenderTextureDescriptor.NativeFieldInfoPtr__stencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<stencilFormat>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__depthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_depthBufferBits");
			RenderTextureDescriptor.NativeFieldInfoPtr_depthFormatBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "depthFormatBits");
			RenderTextureDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__shadowSamplingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<shadowSamplingMode>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__vrUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<vrUsage>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_flags");
			RenderTextureDescriptor.NativeFieldInfoPtr__memoryless_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<memoryless>k__BackingField");
			RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663912);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663913);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663914);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663915);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663916);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663917);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663918);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663919);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663920);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663921);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663922);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663923);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663924);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663925);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663926);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663927);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663928);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663929);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663930);
			RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663931);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663932);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100663933);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000335B8 File Offset: 0x000317B8
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000335E8 File Offset: 0x000317E8
		public unsafe int width
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0003361C File Offset: 0x0003181C
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0003364C File Offset: 0x0003184C
		public unsafe int height
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00033680 File Offset: 0x00031880
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x000336B0 File Offset: 0x000318B0
		public unsafe int msaaSamples
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000336E4 File Offset: 0x000318E4
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00033714 File Offset: 0x00031914
		public unsafe int volumeDepth
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00008EA9 File Offset: 0x000070A9
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00033748 File Offset: 0x00031948
		public unsafe int mipCount
		{
			get
			{
				return this._mipCount_k__BackingField;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003377C File Offset: 0x0003197C
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000337AC File Offset: 0x000319AC
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64704, XrefRangeEnd = 64705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000337E0 File Offset: 0x000319E0
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00033810 File Offset: 0x00031A10
		public unsafe int depthBufferBits
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 64709, RefRangeEnd = 64712, XrefRangeStart = 64705, XrefRangeEnd = 64709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00008EF4 File Offset: 0x000070F4
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00033844 File Offset: 0x00031A44
		public unsafe UnityEngine.Rendering.TextureDimension dimension
		{
			get
			{
				return this._dimension_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00008EFC File Offset: 0x000070FC
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00033878 File Offset: 0x00031A78
		public unsafe UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode
		{
			get
			{
				return this._shadowSamplingMode_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00008F04 File Offset: 0x00007104
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x000338AC File Offset: 0x00031AAC
		public unsafe VRTextureUsage vrUsage
		{
			get
			{
				return this._vrUsage_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00008F0C File Offset: 0x0000710C
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x000338E0 File Offset: 0x00031AE0
		public unsafe RenderTextureMemoryless memoryless
		{
			get
			{
				return this._memoryless_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00033914 File Offset: 0x00031B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64712, XrefRangeEnd = 64717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00033970 File Offset: 0x00031B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64720, RefRangeEnd = 64721, XrefRangeStart = 64717, XrefRangeEnd = 64720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000339DC File Offset: 0x00031BDC
		[CallerCount(0)]
		public unsafe void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00033B88 File Offset: 0x00031D88
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00033A1C File Offset: 0x00031C1C
		public unsafe bool createdFromScript
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.CreatedFromScript) > (RenderTextureCreationFlags)0;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00033BA8 File Offset: 0x00031DA8
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00033A50 File Offset: 0x00031C50
		public unsafe bool useDynamicScale
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.DynamicallyScalable) > (RenderTextureCreationFlags)0;
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00008E85 File Offset: 0x00007085
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00033A84 File Offset: 0x00031C84
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00008E97 File Offset: 0x00007097
		public unsafe static Il2CppStructArray<int> depthFormatBits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderTextureDescriptor.NativeFieldInfoPtr_depthFormatBits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTextureDescriptor.NativeFieldInfoPtr_depthFormatBits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00008EB1 File Offset: 0x000070B1
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00008EB9 File Offset: 0x000070B9
		public UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return this._stencilFormat_k__BackingField;
			}
			set
			{
				this._stencilFormat_k__BackingField = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00033AAC File Offset: 0x00031CAC
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00008EC2 File Offset: 0x000070C2
		public RenderTextureFormat colorFormat
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(this.graphicsFormat);
			}
			set
			{
				this.graphicsFormat = SystemInfo.GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB), UnityEngine.Experimental.Rendering.FormatUsage.Render);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00033ACC File Offset: 0x00031CCC
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00008EDE File Offset: 0x000070DE
		public bool sRGB
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsSRGBFormat(this.graphicsFormat);
			}
			set
			{
				this.graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(this.colorFormat, value);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00033AEC File Offset: 0x00031CEC
		public RenderTextureCreationFlags flags
		{
			get
			{
				return this._flags;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00033B04 File Offset: 0x00031D04
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00008F14 File Offset: 0x00007114
		public bool useMipMap
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.MipMap) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.MipMap);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00033B24 File Offset: 0x00031D24
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00008F20 File Offset: 0x00007120
		public bool autoGenerateMips
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.AutoGenerateMips) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.AutoGenerateMips);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00033B44 File Offset: 0x00031D44
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00008F2C File Offset: 0x0000712C
		public bool enableRandomWrite
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.EnableRandomWrite) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.EnableRandomWrite);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00033B64 File Offset: 0x00031D64
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00008F39 File Offset: 0x00007139
		public bool bindMS
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.BindMS) > (RenderTextureCreationFlags)0;
			}
			set
			{
				this.SetOrClearRenderTextureCreationFlag(value, RenderTextureCreationFlags.BindMS);
			}
		}

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr__msaaSamples_k__BackingField;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr__volumeDepth_k__BackingField;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr__mipCount_k__BackingField;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr__graphicsFormat;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr__stencilFormat_k__BackingField;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr__depthBufferBits;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_depthFormatBits;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr__shadowSamplingMode_k__BackingField;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr__vrUsage_k__BackingField;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr__memoryless_k__BackingField;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x0400086E RID: 2158
		[FieldOffset(0)]
		public int _width_k__BackingField;

		// Token: 0x0400086F RID: 2159
		[FieldOffset(4)]
		public int _height_k__BackingField;

		// Token: 0x04000870 RID: 2160
		[FieldOffset(8)]
		public int _msaaSamples_k__BackingField;

		// Token: 0x04000871 RID: 2161
		[FieldOffset(12)]
		public int _volumeDepth_k__BackingField;

		// Token: 0x04000872 RID: 2162
		[FieldOffset(16)]
		public int _mipCount_k__BackingField;

		// Token: 0x04000873 RID: 2163
		[FieldOffset(20)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;

		// Token: 0x04000874 RID: 2164
		[FieldOffset(24)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _stencilFormat_k__BackingField;

		// Token: 0x04000875 RID: 2165
		[FieldOffset(28)]
		public int _depthBufferBits;

		// Token: 0x04000876 RID: 2166
		[FieldOffset(32)]
		public UnityEngine.Rendering.TextureDimension _dimension_k__BackingField;

		// Token: 0x04000877 RID: 2167
		[FieldOffset(36)]
		public UnityEngine.Rendering.ShadowSamplingMode _shadowSamplingMode_k__BackingField;

		// Token: 0x04000878 RID: 2168
		[FieldOffset(40)]
		public VRTextureUsage _vrUsage_k__BackingField;

		// Token: 0x04000879 RID: 2169
		[FieldOffset(44)]
		public RenderTextureCreationFlags _flags;

		// Token: 0x0400087A RID: 2170
		[FieldOffset(48)]
		public RenderTextureMemoryless _memoryless_k__BackingField;
	}
}
