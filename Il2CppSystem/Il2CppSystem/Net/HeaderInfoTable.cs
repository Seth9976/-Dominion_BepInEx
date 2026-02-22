using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E1 RID: 225
	public class HeaderInfoTable : Object
	{
		// Token: 0x06000D02 RID: 3330 RVA: 0x00041900 File Offset: 0x0003FB00
		// Note: this type is marked as 'beforefieldinit'.
		static HeaderInfoTable()
		{
			Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfoTable");
			HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "HeaderHashTable");
			HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "UnknownHeaderInfo");
			HeaderInfoTable.NativeFieldInfoPtr_SingleParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "SingleParser");
			HeaderInfoTable.NativeFieldInfoPtr_MultiParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, "MultiParser");
			HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665133);
			HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665134);
			HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665136);
			HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr, 100665137);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000419C8 File Offset: 0x0003FBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47521, XrefRangeEnd = 47525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseSingleValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00041A0C File Offset: 0x0003FC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47525, XrefRangeEnd = 47549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseMultiValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170003DF RID: 991
		public unsafe HeaderInfo this[string name]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 47555, RefRangeEnd = 47559, XrefRangeStart = 47549, XrefRangeEnd = 47555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00041AA0 File Offset: 0x0003FCA0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeaderInfoTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfoTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeaderInfoTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000070EA File Offset: 0x000052EA
		public HeaderInfoTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00041ADC File Offset: 0x0003FCDC
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x000070F3 File Offset: 0x000052F3
		public unsafe static Hashtable HeaderHashTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_HeaderHashTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00041B04 File Offset: 0x0003FD04
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00007105 File Offset: 0x00005305
		public unsafe static HeaderInfo UnknownHeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_UnknownHeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00041B2C File Offset: 0x0003FD2C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00007117 File Offset: 0x00005317
		public unsafe static HeaderParser SingleParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_SingleParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00041B54 File Offset: 0x0003FD54
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00007129 File Offset: 0x00005329
		public unsafe static HeaderParser MultiParser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeaderInfoTable.NativeFieldInfoPtr_MultiParser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_HeaderHashTable;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_UnknownHeaderInfo;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_SingleParser;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_MultiParser;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingleValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiValue_Private_Static_Il2CppStringArray_String_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_HeaderInfo_String_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
