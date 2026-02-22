using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;

namespace UTNotifications
{
	// Token: 0x020000F7 RID: 247
	public class JSONData : JSONNode
	{
		// Token: 0x06001DDF RID: 7647 RVA: 0x000754E0 File Offset: 0x000736E0
		// Note: this type is marked as 'beforefieldinit'.
		static JSONData()
		{
			Il2CppClassPointerStore<JSONData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JSONData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONData>.NativeClassPtr);
			JSONData.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONData>.NativeClassPtr, "m_Data");
			JSONData.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665746);
			JSONData.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665747);
			JSONData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665748);
			JSONData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665749);
			JSONData.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665750);
			JSONData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665751);
			JSONData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665752);
			JSONData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665753);
			JSONData.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665754);
			JSONData.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONData>.NativeClassPtr, 100665755);
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000755EC File Offset: 0x000737EC
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00075630 File Offset: 0x00073830
		public unsafe override string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONData.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONData.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00075680 File Offset: 0x00073880
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONData(string aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000756CC File Offset: 0x000738CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255381, XrefRangeEnd = 255382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONData(float aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00075714 File Offset: 0x00073914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255382, XrefRangeEnd = 255383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONData(double aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONData.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0007575C File Offset: 0x0007395C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255383, XrefRangeEnd = 255384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONData(bool aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000757A4 File Offset: 0x000739A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255384, XrefRangeEnd = 255385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONData(int aData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000757EC File Offset: 0x000739EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255385, XrefRangeEnd = 255389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00075830 File Offset: 0x00073A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255389, XrefRangeEnd = 255393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(string aPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONData.NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00075884 File Offset: 0x00073A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255393, XrefRangeEnd = 255403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Serialize(BinaryWriter aWriter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONData.NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00012B7E File Offset: 0x00010D7E
		public JSONData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x000758D4 File Offset: 0x00073AD4
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00012B87 File Offset: 0x00010D87
		public unsafe string m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONData.NativeFieldInfoPtr_m_Data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONData.NativeFieldInfoPtr_m_Data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_String_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Void_BinaryWriter_0;
	}
}
