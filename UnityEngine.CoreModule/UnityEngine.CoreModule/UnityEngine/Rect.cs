using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	[StructLayout(2)]
	public struct Rect
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x000201D0 File Offset: 0x0001E3D0
		// Note: this type is marked as 'beforefieldinit'.
		static Rect()
		{
			Il2CppClassPointerStore<Rect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Rect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rect>.NativeClassPtr);
			Rect.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_XMin");
			Rect.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_YMin");
			Rect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Width");
			Rect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Height");
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663511);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663512);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663513);
			Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663514);
			Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663515);
			Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663516);
			Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663517);
			Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663518);
			Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663519);
			Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663520);
			Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663521);
			Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663522);
			Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663523);
			Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663524);
			Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663525);
			Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663526);
			Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663527);
			Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663528);
			Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663529);
			Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663530);
			Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663531);
			Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663532);
			Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663533);
			Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663534);
			Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663535);
			Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663536);
			Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663537);
			Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663538);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663539);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663540);
			Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663541);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663542);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663543);
			Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663544);
			Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663545);
			Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663546);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663547);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663548);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663549);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100663550);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00020570 File Offset: 0x0001E770
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 61474, RefRangeEnd = 61587, XrefRangeStart = 61474, XrefRangeEnd = 61474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(float x, float y, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000205CC File Offset: 0x0001E7CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 61587, RefRangeEnd = 61593, XrefRangeStart = 61587, XrefRangeEnd = 61587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(Vector2 position, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002060C File Offset: 0x0001E80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61593, RefRangeEnd = 61594, XrefRangeStart = 61593, XrefRangeEnd = 61593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(Rect source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00020640 File Offset: 0x0001E840
		public unsafe static Rect zero
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 61594, RefRangeEnd = 61618, XrefRangeStart = 61594, XrefRangeEnd = 61594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00020670 File Offset: 0x0001E870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61618, RefRangeEnd = 61619, XrefRangeStart = 61618, XrefRangeEnd = 61618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xmin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000206D8 File Offset: 0x0001E8D8
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00020708 File Offset: 0x0001E908
		public unsafe float x
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 61619, RefRangeEnd = 61697, XrefRangeStart = 61619, XrefRangeEnd = 61619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 61697, RefRangeEnd = 61704, XrefRangeStart = 61697, XrefRangeEnd = 61697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0002073C File Offset: 0x0001E93C
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0002076C File Offset: 0x0001E96C
		public unsafe float y
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 61704, RefRangeEnd = 61712, XrefRangeStart = 61704, XrefRangeEnd = 61704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000207A0 File Offset: 0x0001E9A0
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000207D0 File Offset: 0x0001E9D0
		public unsafe Vector2 position
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 61712, RefRangeEnd = 61738, XrefRangeStart = 61712, XrefRangeEnd = 61712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 61738, RefRangeEnd = 61740, XrefRangeStart = 61738, XrefRangeEnd = 61738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00020804 File Offset: 0x0001EA04
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00020834 File Offset: 0x0001EA34
		public unsafe Vector2 center
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 61740, RefRangeEnd = 61753, XrefRangeStart = 61740, XrefRangeEnd = 61740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61753, RefRangeEnd = 61754, XrefRangeStart = 61753, XrefRangeEnd = 61753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00020868 File Offset: 0x0001EA68
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000049C1 File Offset: 0x00002BC1
		public unsafe Vector2 min
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 61754, RefRangeEnd = 61764, XrefRangeStart = 61754, XrefRangeEnd = 61754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00020898 File Offset: 0x0001EA98
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000049DE File Offset: 0x00002BDE
		public unsafe Vector2 max
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 61764, RefRangeEnd = 61772, XrefRangeStart = 61764, XrefRangeEnd = 61764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000208C8 File Offset: 0x0001EAC8
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000208F8 File Offset: 0x0001EAF8
		public unsafe float width
		{
			[CallerCount(139)]
			[CachedScanResults(RefRangeStart = 61772, RefRangeEnd = 61911, XrefRangeStart = 61772, XrefRangeEnd = 61772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 61911, RefRangeEnd = 61923, XrefRangeStart = 61911, XrefRangeEnd = 61911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0002092C File Offset: 0x0001EB2C
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0002095C File Offset: 0x0001EB5C
		public unsafe float height
		{
			[CallerCount(153)]
			[CachedScanResults(RefRangeStart = 61923, RefRangeEnd = 62076, XrefRangeStart = 61923, XrefRangeEnd = 61923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62076, RefRangeEnd = 62088, XrefRangeStart = 62076, XrefRangeEnd = 62076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00020990 File Offset: 0x0001EB90
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x000049FB File Offset: 0x00002BFB
		public unsafe Vector2 size
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 62088, RefRangeEnd = 62133, XrefRangeStart = 62088, XrefRangeEnd = 62088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000209C0 File Offset: 0x0001EBC0
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000209F0 File Offset: 0x0001EBF0
		public unsafe float xMin
		{
			[CallerCount(78)]
			[CachedScanResults(RefRangeStart = 61619, RefRangeEnd = 61697, XrefRangeStart = 61619, XrefRangeEnd = 61697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62133, RefRangeEnd = 62135, XrefRangeStart = 62133, XrefRangeEnd = 62133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00020A24 File Offset: 0x0001EC24
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00020A54 File Offset: 0x0001EC54
		public unsafe float yMin
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 59142, RefRangeEnd = 59224, XrefRangeStart = 59142, XrefRangeEnd = 59224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62135, RefRangeEnd = 62137, XrefRangeStart = 62135, XrefRangeEnd = 62135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00020A88 File Offset: 0x0001EC88
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public unsafe float xMax
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 62137, RefRangeEnd = 62164, XrefRangeStart = 62137, XrefRangeEnd = 62137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62164, RefRangeEnd = 62166, XrefRangeStart = 62164, XrefRangeEnd = 62164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00020AEC File Offset: 0x0001ECEC
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00020B1C File Offset: 0x0001ED1C
		public unsafe float yMax
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 62166, RefRangeEnd = 62190, XrefRangeStart = 62166, XrefRangeEnd = 62166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62190, RefRangeEnd = 62192, XrefRangeStart = 62190, XrefRangeEnd = 62190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00020B50 File Offset: 0x0001ED50
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 62192, RefRangeEnd = 62208, XrefRangeStart = 62192, XrefRangeEnd = 62192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector2 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00020B90 File Offset: 0x0001ED90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62208, RefRangeEnd = 62212, XrefRangeStart = 62208, XrefRangeEnd = 62208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00020BD0 File Offset: 0x0001EDD0
		[CallerCount(0)]
		public unsafe static Rect OrderMinMax(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00020C10 File Offset: 0x0001EE10
		[CallerCount(0)]
		public unsafe bool Overlaps(Rect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00020C50 File Offset: 0x0001EE50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62213, RefRangeEnd = 62217, XrefRangeStart = 62212, XrefRangeEnd = 62213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(Rect other, bool allowInverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00020C9C File Offset: 0x0001EE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62217, RefRangeEnd = 62219, XrefRangeStart = 62217, XrefRangeEnd = 62217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Rect lhs, Rect rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62219, RefRangeEnd = 62221, XrefRangeStart = 62219, XrefRangeEnd = 62219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Rect lhs, Rect rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00020D34 File Offset: 0x0001EF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62221, XrefRangeEnd = 62225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00020D64 File Offset: 0x0001EF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62225, XrefRangeEnd = 62232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62232, XrefRangeEnd = 62236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Rect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62236, XrefRangeEnd = 62237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00020E14 File Offset: 0x0001F014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62258, RefRangeEnd = 62259, XrefRangeStart = 62237, XrefRangeEnd = 62258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000498F File Offset: 0x00002B8F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rect>.NativeClassPtr, ref this));
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000049A1 File Offset: 0x00002BA1
		public void Set(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00020E64 File Offset: 0x0001F064
		public bool Contains(Vector3 point, bool allowInverse)
		{
			bool flag = !allowInverse;
			bool flag2;
			if (flag)
			{
				flag2 = this.Contains(point);
			}
			else
			{
				bool flag3 = (this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax);
				bool flag4 = (this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax);
				flag2 = flag3 && flag4;
			}
			return flag2;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00020F44 File Offset: 0x0001F144
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00020F90 File Offset: 0x0001F190
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00020FDC File Offset: 0x0001F1DC
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00021010 File Offset: 0x0001F210
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00021030 File Offset: 0x0001F230
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00021048 File Offset: 0x0001F248
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector2_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector2_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector2_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Single_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Single_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Single_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Single_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400030F RID: 783
		[FieldOffset(0)]
		public float m_XMin;

		// Token: 0x04000310 RID: 784
		[FieldOffset(4)]
		public float m_YMin;

		// Token: 0x04000311 RID: 785
		[FieldOffset(8)]
		public float m_Width;

		// Token: 0x04000312 RID: 786
		[FieldOffset(12)]
		public float m_Height;
	}
}
