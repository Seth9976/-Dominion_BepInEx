using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppMono.Net.Security
{
	// Token: 0x0200001A RID: 26
	public class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00014E54 File Offset: 0x00013054
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize2()
		{
			Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "BufferOffsetSize2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr);
			BufferOffsetSize2.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, "InitialSize");
			BufferOffsetSize2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663527);
			BufferOffsetSize2.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663528);
			BufferOffsetSize2.NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663529);
			BufferOffsetSize2.NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr, 100663530);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00014EE8 File Offset: 0x000130E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33245, RefRangeEnd = 33247, XrefRangeStart = 33241, XrefRangeEnd = 33245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize2(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00014F30 File Offset: 0x00013130
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33250, RefRangeEnd = 33256, XrefRangeStart = 33247, XrefRangeEnd = 33250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00014F64 File Offset: 0x00013164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33256, XrefRangeEnd = 33259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeRoom(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00014FA4 File Offset: 0x000131A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 33267, RefRangeEnd = 33269, XrefRangeStart = 33259, XrefRangeEnd = 33267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendData(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize2.NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002671 File Offset: 0x00000871
		public BufferOffsetSize2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00015004 File Offset: 0x00013204
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000267A File Offset: 0x0000087A
		public unsafe int InitialSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize2.NativeFieldInfoPtr_InitialSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BufferOffsetSize2.NativeFieldInfoPtr_InitialSize)) = value;
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_MakeRoom_Public_Void_Int32_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_AppendData_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
