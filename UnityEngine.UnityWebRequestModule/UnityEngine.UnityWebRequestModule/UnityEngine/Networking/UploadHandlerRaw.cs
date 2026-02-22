using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x0200000B RID: 11
	public sealed class UploadHandlerRaw : UploadHandler
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00006B44 File Offset: 0x00004D44
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandlerRaw()
		{
			Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandlerRaw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr);
			UploadHandlerRaw.NativeFieldInfoPtr_m_Payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, "m_Payload");
			UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663416);
			UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663417);
			UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663418);
			UploadHandlerRaw.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663419);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006BD8 File Offset: 0x00004DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124850, XrefRangeEnd = 124852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(UploadHandlerRaw self, byte* data, int dataLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006C34 File Offset: 0x00004E34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124865, RefRangeEnd = 124868, XrefRangeStart = 124852, XrefRangeEnd = 124865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandlerRaw(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006C80 File Offset: 0x00004E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124868, XrefRangeEnd = 124880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandlerRaw(NativeArray<byte> data, bool transferOwnership)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transferOwnership;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006CE0 File Offset: 0x00004EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124880, XrefRangeEnd = 124890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000025F3 File Offset: 0x000007F3
		public UploadHandlerRaw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00006D14 File Offset: 0x00004F14
		// (set) Token: 0x06000142 RID: 322 RVA: 0x000025FC File Offset: 0x000007FC
		public NativeArray<byte> m_Payload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandlerRaw.NativeFieldInfoPtr_m_Payload);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandlerRaw.NativeFieldInfoPtr_m_Payload), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000262A File Offset: 0x0000082A
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_m_Payload;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_ptr_Byte_Int32_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Byte_Boolean_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
