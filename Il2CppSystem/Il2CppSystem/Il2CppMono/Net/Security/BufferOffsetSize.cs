using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000019 RID: 25
	public class BufferOffsetSize : Object
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00014B7C File Offset: 0x00012D7C
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize()
		{
			Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "BufferOffsetSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr);
			BufferOffsetSize.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Buffer");
			BufferOffsetSize.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Offset");
			BufferOffsetSize.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Size");
			BufferOffsetSize.NativeFieldInfoPtr_TotalBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "TotalBytes");
			BufferOffsetSize.NativeFieldInfoPtr_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Complete");
			BufferOffsetSize.NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663523);
			BufferOffsetSize.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663524);
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663525);
			BufferOffsetSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100663526);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00014C60 File Offset: 0x00012E60
		public unsafe int EndOffset
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 33226, RefRangeEnd = 33228, XrefRangeStart = 33226, XrefRangeEnd = 33226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00014C9C File Offset: 0x00012E9C
		public unsafe int Remaining
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 33228, RefRangeEnd = 33231, XrefRangeStart = 33228, XrefRangeEnd = 33228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014CD8 File Offset: 0x00012ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33232, RefRangeEnd = 33233, XrefRangeStart = 33231, XrefRangeEnd = 33232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, int offset, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00014D40 File Offset: 0x00012F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33233, XrefRangeEnd = 33241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BufferOffsetSize.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000025DD File Offset: 0x000007DD
		public BufferOffsetSize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00014D84 File Offset: 0x00012F84
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000025E6 File Offset: 0x000007E6
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00014DB4 File Offset: 0x00012FB4
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00014DDC File Offset: 0x00012FDC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00002620 File Offset: 0x00000820
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00014E04 File Offset: 0x00013004
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000263B File Offset: 0x0000083B
		public unsafe int TotalBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_TotalBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_TotalBytes)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00014E2C File Offset: 0x0001302C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002656 File Offset: 0x00000856
		public unsafe bool Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize.NativeFieldInfoPtr_Complete)) = value;
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_TotalBytes;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_Complete;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOffset_Public_get_Int32_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_get_Int32_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
