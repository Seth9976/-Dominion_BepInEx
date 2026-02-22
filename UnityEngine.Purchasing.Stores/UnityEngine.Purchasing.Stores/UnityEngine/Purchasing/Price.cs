using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class Price : Object
	{
		// Token: 0x0600039A RID: 922 RVA: 0x00011D44 File Offset: 0x0000FF44
		// Note: this type is marked as 'beforefieldinit'.
		static Price()
		{
			Il2CppClassPointerStore<Price>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "Price");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Price>.NativeClassPtr);
			Price.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Price>.NativeClassPtr, "value");
			Price.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Price>.NativeClassPtr, "data");
			Price.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Price>.NativeClassPtr, "num");
			Price.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Price>.NativeClassPtr, 100663748);
			Price.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Price>.NativeClassPtr, 100663749);
			Price.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Price>.NativeClassPtr, 100663750);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00011DEC File Offset: 0x0000FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154960, XrefRangeEnd = 154965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Price.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00011E20 File Offset: 0x00010020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154965, XrefRangeEnd = 154966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Price.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00011E54 File Offset: 0x00010054
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Price()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Price>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Price.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003D08 File Offset: 0x00001F08
		public Price(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00011E90 File Offset: 0x00010090
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003D11 File Offset: 0x00001F11
		public unsafe Decimal value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00011EB8 File Offset: 0x000100B8
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003D2C File Offset: 0x00001F2C
		public unsafe Il2CppStructArray<int> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00011EE8 File Offset: 0x000100E8
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003D4B File Offset: 0x00001F4B
		public unsafe double num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Price.NativeFieldInfoPtr_num)) = value;
			}
		}

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
