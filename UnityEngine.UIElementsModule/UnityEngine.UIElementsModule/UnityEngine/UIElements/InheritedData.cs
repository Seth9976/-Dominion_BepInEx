using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B7 RID: 183
	public sealed class InheritedData : ValueType
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x0002C18C File Offset: 0x0002A38C
		// Note: this type is marked as 'beforefieldinit'.
		static InheritedData()
		{
			Il2CppClassPointerStore<InheritedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "InheritedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InheritedData>.NativeClassPtr);
			InheritedData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "color");
			InheritedData.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "fontSize");
			InheritedData.NativeFieldInfoPtr_unityFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityFont");
			InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityFontStyleAndWeight");
			InheritedData.NativeFieldInfoPtr_unityTextAlign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "unityTextAlign");
			InheritedData.NativeFieldInfoPtr_visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "visibility");
			InheritedData.NativeFieldInfoPtr_whiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, "whiteSpace");
			InheritedData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100664192);
			InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100664193);
			InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100664194);
			InheritedData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InheritedData>.NativeClassPtr, 100664195);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002C298 File Offset: 0x0002A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96731, XrefRangeEnd = 96737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InheritedData lhs, InheritedData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96743, RefRangeEnd = 96744, XrefRangeStart = 96737, XrefRangeEnd = 96743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InheritedData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002C350 File Offset: 0x0002A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96744, XrefRangeEnd = 96748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002C3A4 File Offset: 0x0002A5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96748, XrefRangeEnd = 96755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InheritedData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00006505 File Offset: 0x00004705
		public InheritedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000650E File Offset: 0x0000470E
		public InheritedData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InheritedData>.NativeClassPtr))
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006520 File Offset: 0x00004720
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002C410 File Offset: 0x0002A610
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0000653B File Offset: 0x0000473B
		public unsafe Length fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002C438 File Offset: 0x0002A638
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00006556 File Offset: 0x00004756
		public unsafe Font unityFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002C468 File Offset: 0x0002A668
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00006575 File Offset: 0x00004775
		public unsafe FontStyle unityFontStyleAndWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityFontStyleAndWeight)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002C490 File Offset: 0x0002A690
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00006590 File Offset: 0x00004790
		public unsafe TextAnchor unityTextAlign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextAlign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_unityTextAlign)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x000065AB File Offset: 0x000047AB
		public unsafe Visibility visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_visibility)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000065C6 File Offset: 0x000047C6
		public unsafe WhiteSpace whiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_whiteSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InheritedData.NativeFieldInfoPtr_whiteSpace)) = value;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002C508 File Offset: 0x0002A708
		public static bool operator !=(InheritedData lhs, InheritedData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_unityFont;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_unityFontStyleAndWeight;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_unityTextAlign;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_visibility;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_whiteSpace;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InheritedData_InheritedData_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InheritedData_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
