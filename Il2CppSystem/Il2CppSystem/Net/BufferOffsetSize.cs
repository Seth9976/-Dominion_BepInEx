using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DE RID: 222
	public class BufferOffsetSize : Object
	{
		// Token: 0x06000CE4 RID: 3300 RVA: 0x0004141C File Offset: 0x0003F61C
		// Note: this type is marked as 'beforefieldinit'.
		static BufferOffsetSize()
		{
			Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BufferOffsetSize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr);
			BufferOffsetSize.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Buffer");
			BufferOffsetSize.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Offset");
			BufferOffsetSize.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, "Size");
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100665128);
			BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr, 100665129);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000414B0 File Offset: 0x0003F6B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 47508, RefRangeEnd = 47513, XrefRangeStart = 47503, XrefRangeEnd = 47508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, int offset, int size, bool copyBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00041528 File Offset: 0x0003F728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47518, RefRangeEnd = 47520, XrefRangeStart = 47513, XrefRangeEnd = 47518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BufferOffsetSize(Il2CppStructArray<byte> buffer, bool copyBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferOffsetSize>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferOffsetSize.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00006FC4 File Offset: 0x000051C4
		public BufferOffsetSize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00041584 File Offset: 0x0003F784
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00006FCD File Offset: 0x000051CD
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

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000415B4 File Offset: 0x0003F7B4
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00006FEC File Offset: 0x000051EC
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000415DC File Offset: 0x0003F7DC
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00007007 File Offset: 0x00005207
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

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_Boolean_0;
	}
}
