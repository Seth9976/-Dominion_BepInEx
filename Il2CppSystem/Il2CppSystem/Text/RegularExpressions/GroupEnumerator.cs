using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000056 RID: 86
	public class GroupEnumerator : Object
	{
		// Token: 0x060005C7 RID: 1479 RVA: 0x00025DFC File Offset: 0x00023FFC
		// Note: this type is marked as 'beforefieldinit'.
		static GroupEnumerator()
		{
			Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "GroupEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr);
			GroupEnumerator.NativeFieldInfoPtr__rgc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, "_rgc");
			GroupEnumerator.NativeFieldInfoPtr__curindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, "_curindex");
			GroupEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664057);
			GroupEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664058);
			GroupEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664059);
			GroupEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664060);
			GroupEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr, 100664061);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00025EB8 File Offset: 0x000240B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupEnumerator(GroupCollection rgc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00025F04 File Offset: 0x00024104
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00025F40 File Offset: 0x00024140
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39264, XrefRangeEnd = 39284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00025F80 File Offset: 0x00024180
		public unsafe Capture Capture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_get_Capture_Public_get_Capture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Capture>(intPtr3) : null;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00025FC0 File Offset: 0x000241C0
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000043CD File Offset: 0x000025CD
		public GroupEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00025FF4 File Offset: 0x000241F4
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x000043D6 File Offset: 0x000025D6
		public unsafe GroupCollection _rgc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__rgc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__rgc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00026024 File Offset: 0x00024224
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x000043F5 File Offset: 0x000025F5
		public unsafe int _curindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__curindex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupEnumerator.NativeFieldInfoPtr__curindex)) = value;
			}
		}

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr__rgc;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr__curindex;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GroupCollection_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_get_Capture_Public_get_Capture_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
