using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000055 RID: 85
	[Serializable]
	public class GroupCollection : Object
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x000259B0 File Offset: 0x00023BB0
		// Note: this type is marked as 'beforefieldinit'.
		static GroupCollection()
		{
			Il2CppClassPointerStore<GroupCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "GroupCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr);
			GroupCollection.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_match");
			GroupCollection.NativeFieldInfoPtr__captureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_captureMap");
			GroupCollection.NativeFieldInfoPtr__groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, "_groups");
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664048);
			GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664049);
			GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664050);
			GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664051);
			GroupCollection.NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664052);
			GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664053);
			GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664054);
			GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664055);
			GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr, 100664056);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00025AD0 File Offset: 0x00023CD0
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection(Match match, Hashtable caps)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00025B30 File Offset: 0x00023D30
		public unsafe virtual int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39207, RefRangeEnd = 39209, XrefRangeStart = 39207, XrefRangeEnd = 39207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001DF RID: 479
		public unsafe Group this[int groupnum]
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 39210, RefRangeEnd = 39218, XrefRangeStart = 39209, XrefRangeEnd = 39210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref groupnum;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		public unsafe Group this[string groupname]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39224, RefRangeEnd = 39225, XrefRangeStart = 39218, XrefRangeEnd = 39224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(groupname);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_get_Item_Public_get_Group_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00025C08 File Offset: 0x00023E08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39236, RefRangeEnd = 39241, XrefRangeStart = 39225, XrefRangeEnd = 39236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroup(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00025C54 File Offset: 0x00023E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39252, RefRangeEnd = 39254, XrefRangeStart = 39241, XrefRangeEnd = 39252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Group GetGroupImpl(int groupnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref groupnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Group>(intPtr3) : null;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00025CA0 File Offset: 0x00023EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39254, XrefRangeEnd = 39257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00025CF0 File Offset: 0x00023EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39257, XrefRangeEnd = 39261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00025D30 File Offset: 0x00023F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39261, XrefRangeEnd = 39264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004367 File Offset: 0x00002567
		public GroupCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00025D6C File Offset: 0x00023F6C
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004370 File Offset: 0x00002570
		public unsafe Match _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00025D9C File Offset: 0x00023F9C
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000438F File Offset: 0x0000258F
		public unsafe Hashtable _captureMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__captureMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00025DCC File Offset: 0x00023FCC
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x000043AE File Offset: 0x000025AE
		public unsafe Il2CppReferenceArray<Group> _groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Group>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupCollection.NativeFieldInfoPtr__groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr__captureMap;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr__groups;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Match_Hashtable_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Group_Int32_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Group_String_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Internal_Group_Int32_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_GetGroupImpl_Internal_Group_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
