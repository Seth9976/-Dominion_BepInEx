using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000003 RID: 3
	public class IDs : Object
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002CC0 File Offset: 0x00000EC0
		// Note: this type is marked as 'beforefieldinit'.
		static IDs()
		{
			Il2CppClassPointerStore<IDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDs>.NativeClassPtr);
			IDs.NativeFieldInfoPtr_m_Dic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IDs>.NativeClassPtr, "m_Dic");
			IDs.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100663300);
			IDs.NativeMethodInfoPtr_Add_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100663301);
			IDs.NativeMethodInfoPtr_SpecificIDForStore_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100663302);
			IDs.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100663303);
			IDs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002D68 File Offset: 0x00000F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130496, XrefRangeEnd = 130502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130506, RefRangeEnd = 130507, XrefRangeStart = 130502, XrefRangeEnd = 130506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string id, [Optional] Il2CppStringArray stores)
		{
			if (stores == null)
			{
				stores = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stores);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr_Add_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002E0C File Offset: 0x0000100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130507, XrefRangeEnd = 130511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SpecificIDForStore(string store, string defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr_SpecificIDForStore_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E68 File Offset: 0x00001068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130517, RefRangeEnd = 130518, XrefRangeStart = 130511, XrefRangeEnd = 130517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002EA8 File Offset: 0x000010A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130525, RefRangeEnd = 130526, XrefRangeStart = 130518, XrefRangeEnd = 130525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IDs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002078 File Offset: 0x00000278
		public void Add(string id, params string[] stores)
		{
			this.Add(id, new Il2CppStringArray(stores));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002087 File Offset: 0x00000287
		public IDs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002EE4 File Offset: 0x000010E4
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002090 File Offset: 0x00000290
		public unsafe Dictionary<string, string> m_Dic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_m_Dic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_m_Dic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_Dic;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Il2CppStringArray_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_SpecificIDForStore_Internal_String_String_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
