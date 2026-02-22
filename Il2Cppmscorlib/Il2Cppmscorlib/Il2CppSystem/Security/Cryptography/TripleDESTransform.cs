using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200031D RID: 797
	public class TripleDESTransform : SymmetricTransform
	{
		// Token: 0x060033C8 RID: 13256 RVA: 0x000FE030 File Offset: 0x000FC230
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDESTransform()
		{
			Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDESTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr);
			TripleDESTransform.NativeFieldInfoPtr_E1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E1");
			TripleDESTransform.NativeFieldInfoPtr_D2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D2");
			TripleDESTransform.NativeFieldInfoPtr_E3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E3");
			TripleDESTransform.NativeFieldInfoPtr_D1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D1");
			TripleDESTransform.NativeFieldInfoPtr_E2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "E2");
			TripleDESTransform.NativeFieldInfoPtr_D3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, "D3");
			TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671328);
			TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671329);
			TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr, 100671330);
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000FE114 File Offset: 0x000FC314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342075, RefRangeEnd = 342077, XrefRangeStart = 342045, XrefRangeEnd = 342075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDESTransform(TripleDES algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDESTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000FE194 File Offset: 0x000FC394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342077, XrefRangeEnd = 342092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDESTransform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000FE1F4 File Offset: 0x000FC3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342111, RefRangeEnd = 342112, XrefRangeStart = 342092, XrefRangeEnd = 342111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetStrongKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDESTransform.NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00012820 File Offset: 0x00010A20
		public TripleDESTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000FE228 File Offset: 0x000FC428
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x00012829 File Offset: 0x00010A29
		public unsafe DESTransform E1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000FE258 File Offset: 0x000FC458
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x00012848 File Offset: 0x00010A48
		public unsafe DESTransform D2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x000FE288 File Offset: 0x000FC488
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x00012867 File Offset: 0x00010A67
		public unsafe DESTransform E3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x000FE2B8 File Offset: 0x000FC4B8
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x00012886 File Offset: 0x00010A86
		public unsafe DESTransform D1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x000FE2E8 File Offset: 0x000FC4E8
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x000128A5 File Offset: 0x00010AA5
		public unsafe DESTransform E2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_E2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x000FE318 File Offset: 0x000FC518
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x000128C4 File Offset: 0x00010AC4
		public unsafe DESTransform D3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DESTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TripleDESTransform.NativeFieldInfoPtr_D3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeFieldInfoPtr_E1;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeFieldInfoPtr_D2;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeFieldInfoPtr_E3;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeFieldInfoPtr_D1;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeFieldInfoPtr_E2;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeFieldInfoPtr_D3;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TripleDES_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_GetStrongKey_Internal_Static_Il2CppStructArray_1_Byte_0;
	}
}
