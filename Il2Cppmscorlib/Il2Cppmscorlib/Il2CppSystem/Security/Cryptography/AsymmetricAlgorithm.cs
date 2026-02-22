using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D5 RID: 725
	public class AsymmetricAlgorithm : Object
	{
		// Token: 0x06003033 RID: 12339 RVA: 0x000F1190 File Offset: 0x000EF390
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricAlgorithm()
		{
			Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr);
			AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, "KeySizeValue");
			AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, "LegalKeySizesValue");
			AsymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670895);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670896);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670897);
			AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670898);
			AsymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670899);
			AsymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670900);
			AsymmetricAlgorithm.NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670901);
			AsymmetricAlgorithm.NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr, 100670902);
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x000F1288 File Offset: 0x000EF488
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000F12C4 File Offset: 0x000EF4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338836, RefRangeEnd = 338838, XrefRangeStart = 338832, XrefRangeEnd = 338836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x000F12F8 File Offset: 0x000EF4F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338836, RefRangeEnd = 338838, XrefRangeStart = 338836, XrefRangeEnd = 338838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x000F132C File Offset: 0x000EF52C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000F1378 File Offset: 0x000EF578
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x000F13C0 File Offset: 0x000EF5C0
		public unsafe virtual int KeySize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 338841, RefRangeEnd = 338844, XrefRangeStart = 338838, XrefRangeEnd = 338841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000F140C File Offset: 0x000EF60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338844, XrefRangeEnd = 338849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000F145C File Offset: 0x000EF65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338849, XrefRangeEnd = 338854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricAlgorithm.NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00011028 File Offset: 0x0000F228
		public AsymmetricAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x000F14AC File Offset: 0x000EF6AC
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x00011031 File Offset: 0x0000F231
		public unsafe int KeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue)) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x000F14D4 File Offset: 0x000EF6D4
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x0001104C File Offset: 0x0000F24C
		public unsafe Il2CppReferenceArray<KeySizes> LegalKeySizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeFieldInfoPtr_KeySizeValue;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeFieldInfoPtr_LegalKeySizesValue;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_New_Void_String_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_New_String_Boolean_0;
	}
}
