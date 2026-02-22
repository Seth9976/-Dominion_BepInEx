using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F0 RID: 752
	public class KeyedHashAlgorithm : HashAlgorithm
	{
		// Token: 0x06003137 RID: 12599 RVA: 0x000F4DDC File Offset: 0x000F2FDC
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedHashAlgorithm()
		{
			Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "KeyedHashAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr);
			KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, "KeyValue");
			KeyedHashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100671023);
			KeyedHashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100671024);
			KeyedHashAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100671025);
			KeyedHashAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100671026);
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x000F4E70 File Offset: 0x000F3070
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedHashAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedHashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000F4EAC File Offset: 0x000F30AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339782, RefRangeEnd = 339784, XrefRangeStart = 339780, XrefRangeEnd = 339782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x000F4EF8 File Offset: 0x000F30F8
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x000F4F44 File Offset: 0x000F3144
		public unsafe virtual Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339784, XrefRangeEnd = 339787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339787, XrefRangeEnd = 339791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000116B6 File Offset: 0x0000F8B6
		public KeyedHashAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000F4F94 File Offset: 0x000F3194
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x000116BF File Offset: 0x0000F8BF
		public unsafe Il2CppStructArray<byte> KeyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;
	}
}
