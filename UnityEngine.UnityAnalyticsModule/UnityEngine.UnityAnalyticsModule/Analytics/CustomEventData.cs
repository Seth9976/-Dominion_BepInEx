using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000A RID: 10
	public class CustomEventData : Object
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000045BC File Offset: 0x000027BC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomEventData()
		{
			Il2CppClassPointerStore<CustomEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "CustomEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr);
			CustomEventData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, "m_Ptr");
			CustomEventData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663315);
			CustomEventData.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663316);
			CustomEventData.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663317);
			CustomEventData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663318);
			CustomEventData.NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_CustomEventData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663319);
			CustomEventData.NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663320);
			CustomEventData.NativeMethodInfoPtr_AddString_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663321);
			CustomEventData.NativeMethodInfoPtr_AddInt32_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663322);
			CustomEventData.NativeMethodInfoPtr_AddUInt32_Public_Boolean_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663323);
			CustomEventData.NativeMethodInfoPtr_AddInt64_Public_Boolean_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663324);
			CustomEventData.NativeMethodInfoPtr_AddUInt64_Public_Boolean_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663325);
			CustomEventData.NativeMethodInfoPtr_AddBool_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663326);
			CustomEventData.NativeMethodInfoPtr_AddDouble_Public_Boolean_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663327);
			CustomEventData.NativeMethodInfoPtr_AddDictionary_Public_Boolean_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr, 100663328);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004718 File Offset: 0x00002918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123635, XrefRangeEnd = 123638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomEventData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004764 File Offset: 0x00002964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123638, XrefRangeEnd = 123642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomEventData.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000047A0 File Offset: 0x000029A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123646, RefRangeEnd = 123649, XrefRangeStart = 123642, XrefRangeEnd = 123646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000047D4 File Offset: 0x000029D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123649, XrefRangeEnd = 123654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004808 File Offset: 0x00002A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123654, XrefRangeEnd = 123656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(CustomEventData ced, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ced);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_CustomEventData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000485C File Offset: 0x00002A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123656, XrefRangeEnd = 123658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004890 File Offset: 0x00002A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123660, RefRangeEnd = 123663, XrefRangeStart = 123658, XrefRangeEnd = 123660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddString(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddString_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000048F0 File Offset: 0x00002AF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123665, RefRangeEnd = 123669, XrefRangeStart = 123663, XrefRangeEnd = 123665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddInt32(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddInt32_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000494C File Offset: 0x00002B4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123671, RefRangeEnd = 123673, XrefRangeStart = 123669, XrefRangeEnd = 123671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddUInt32(string key, uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddUInt32_Public_Boolean_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000049A8 File Offset: 0x00002BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123675, RefRangeEnd = 123676, XrefRangeStart = 123673, XrefRangeEnd = 123675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddInt64(string key, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddInt64_Public_Boolean_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004A04 File Offset: 0x00002C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123678, RefRangeEnd = 123679, XrefRangeStart = 123676, XrefRangeEnd = 123678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddUInt64(string key, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddUInt64_Public_Boolean_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004A60 File Offset: 0x00002C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123681, RefRangeEnd = 123682, XrefRangeStart = 123679, XrefRangeEnd = 123681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddBool(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddBool_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004ABC File Offset: 0x00002CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123684, RefRangeEnd = 123686, XrefRangeStart = 123682, XrefRangeEnd = 123684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDouble(string key, double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddDouble_Public_Boolean_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004B18 File Offset: 0x00002D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123864, RefRangeEnd = 123865, XrefRangeStart = 123686, XrefRangeEnd = 123864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDictionary(IDictionary<string, Object> eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEventData.NativeMethodInfoPtr_AddDictionary_Public_Boolean_IDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000026FE File Offset: 0x000008FE
		public CustomEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00004B68 File Offset: 0x00002D68
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002707 File Offset: 0x00000907
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomEventData.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomEventData.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_CustomEventData_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Public_Boolean_String_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_AddInt32_Public_Boolean_String_Int32_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_AddUInt32_Public_Boolean_String_UInt32_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_AddInt64_Public_Boolean_String_Int64_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_AddUInt64_Public_Boolean_String_UInt64_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_AddBool_Public_Boolean_String_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_AddDouble_Public_Boolean_String_Double_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_AddDictionary_Public_Boolean_IDictionary_2_String_Object_0;
	}
}
