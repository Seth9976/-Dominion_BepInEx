using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000317 RID: 791
	public class RC2Transform : SymmetricTransform
	{
		// Token: 0x06003382 RID: 13186 RVA: 0x000FD218 File Offset: 0x000FB418
		// Note: this type is marked as 'beforefieldinit'.
		static RC2Transform()
		{
			Il2CppClassPointerStore<RC2Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr);
			RC2Transform.NativeFieldInfoPtr_R0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R0");
			RC2Transform.NativeFieldInfoPtr_R1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R1");
			RC2Transform.NativeFieldInfoPtr_R2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R2");
			RC2Transform.NativeFieldInfoPtr_R3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R3");
			RC2Transform.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "K");
			RC2Transform.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "j");
			RC2Transform.NativeFieldInfoPtr_pitable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "pitable");
			RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100671298);
			RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100671299);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000FD2FC File Offset: 0x000FB4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341932, RefRangeEnd = 341934, XrefRangeStart = 341905, XrefRangeEnd = 341932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2Transform(RC2 rc2Algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rc2Algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000FD37C File Offset: 0x000FB57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341934, XrefRangeEnd = 341938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000125E1 File Offset: 0x000107E1
		public RC2Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x000FD3DC File Offset: 0x000FB5DC
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x000125EA File Offset: 0x000107EA
		public unsafe ushort R0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0)) = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x000FD404 File Offset: 0x000FB604
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00012605 File Offset: 0x00010805
		public unsafe ushort R1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1)) = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000FD42C File Offset: 0x000FB62C
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00012620 File Offset: 0x00010820
		public unsafe ushort R2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2)) = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x000FD454 File Offset: 0x000FB654
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x0001263B File Offset: 0x0001083B
		public unsafe ushort R3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3)) = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000FD47C File Offset: 0x000FB67C
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x00012656 File Offset: 0x00010856
		public unsafe Il2CppStructArray<ushort> K
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000FD4AC File Offset: 0x000FB6AC
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00012675 File Offset: 0x00010875
		public unsafe int j
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j)) = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x000FD4D4 File Offset: 0x000FB6D4
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x00012690 File Offset: 0x00010890
		public unsafe static Il2CppStructArray<byte> pitable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2Transform.NativeFieldInfoPtr_pitable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2Transform.NativeFieldInfoPtr_pitable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeFieldInfoPtr_R0;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeFieldInfoPtr_R1;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeFieldInfoPtr_R2;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeFieldInfoPtr_R3;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeFieldInfoPtr_pitable;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
