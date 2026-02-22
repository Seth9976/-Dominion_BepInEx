using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000207 RID: 519
	[Serializable]
	public class MemoryStream : Stream
	{
		// Token: 0x06002122 RID: 8482 RVA: 0x000B7098 File Offset: 0x000B5298
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryStream()
		{
			Il2CppClassPointerStore<MemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr);
			MemoryStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_buffer");
			MemoryStream.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_origin");
			MemoryStream.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_position");
			MemoryStream.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_length");
			MemoryStream.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_capacity");
			MemoryStream.NativeFieldInfoPtr__expandable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_expandable");
			MemoryStream.NativeFieldInfoPtr__writable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_writable");
			MemoryStream.NativeFieldInfoPtr__exposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_exposable");
			MemoryStream.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_isOpen");
			MemoryStream.NativeFieldInfoPtr__lastReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, "_lastReadTask");
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668782);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668783);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668784);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668785);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668786);
			MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668787);
			MemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668788);
			MemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668789);
			MemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668790);
			MemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668791);
			MemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668792);
			MemoryStream.NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668793);
			MemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668794);
			MemoryStream.NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668795);
			MemoryStream.NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668796);
			MemoryStream.NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668797);
			MemoryStream.NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668798);
			MemoryStream.NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668799);
			MemoryStream.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668800);
			MemoryStream.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668801);
			MemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668802);
			MemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668803);
			MemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668804);
			MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668805);
			MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668806);
			MemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668807);
			MemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668808);
			MemoryStream.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668809);
			MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668810);
			MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668811);
			MemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr, 100668812);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000B73FC File Offset: 0x000B55FC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 321005, RefRangeEnd = 321020, XrefRangeStart = 320998, XrefRangeEnd = 321005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000B7438 File Offset: 0x000B5638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321027, RefRangeEnd = 321030, XrefRangeStart = 321020, XrefRangeEnd = 321027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000B7480 File Offset: 0x000B5680
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 321034, RefRangeEnd = 321046, XrefRangeStart = 321030, XrefRangeEnd = 321034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000B74CC File Offset: 0x000B56CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321046, XrefRangeEnd = 321050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, bool writable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000B7528 File Offset: 0x000B5728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321050, XrefRangeEnd = 321051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, int index, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000B7590 File Offset: 0x000B5790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321055, RefRangeEnd = 321056, XrefRangeStart = 321051, XrefRangeEnd = 321055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryStream(Il2CppStructArray<byte> buffer, int index, int count, bool writable, bool publiclyVisible)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publiclyVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000B7614 File Offset: 0x000B5814
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600212A RID: 8490 RVA: 0x000B765C File Offset: 0x000B585C
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000B76A4 File Offset: 0x000B58A4
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000B76EC File Offset: 0x000B58EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321056, XrefRangeEnd = 321057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureWriteable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000B7720 File Offset: 0x000B5920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321057, XrefRangeEnd = 321060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000B776C File Offset: 0x000B596C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321060, RefRangeEnd = 321062, XrefRangeStart = 321060, XrefRangeEnd = 321060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureCapacity(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000B77B8 File Offset: 0x000B59B8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000B77F4 File Offset: 0x000B59F4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000B7840 File Offset: 0x000B5A40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> InternalGetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x000B7880 File Offset: 0x000B5A80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321063, RefRangeEnd = 321064, XrefRangeStart = 321062, XrefRangeEnd = 321063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000B78BC File Offset: 0x000B5ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321064, XrefRangeEnd = 321066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000B78F8 File Offset: 0x000B5AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321067, RefRangeEnd = 321068, XrefRangeStart = 321066, XrefRangeEnd = 321067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalEmulateRead(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryStream.NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000B7944 File Offset: 0x000B5B44
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x000B798C File Offset: 0x000B5B8C
		public unsafe virtual int Capacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321068, XrefRangeEnd = 321069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321069, XrefRangeEnd = 321072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000B79D8 File Offset: 0x000B5BD8
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321072, XrefRangeEnd = 321073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x000B7A20 File Offset: 0x000B5C20
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x000B7A68 File Offset: 0x000B5C68
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321073, XrefRangeEnd = 321074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321075, RefRangeEnd = 321076, XrefRangeStart = 321074, XrefRangeEnd = 321075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000B7AB4 File Offset: 0x000B5CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321076, XrefRangeEnd = 321078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000B7B3C File Offset: 0x000B5D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321078, XrefRangeEnd = 321103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000B7BCC File Offset: 0x000B5DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321103, XrefRangeEnd = 321104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000B7C14 File Offset: 0x000B5E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321104, XrefRangeEnd = 321107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000B7C78 File Offset: 0x000B5E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321107, XrefRangeEnd = 321112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x000B7CC4 File Offset: 0x000B5EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321112, XrefRangeEnd = 321118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x000B7D30 File Offset: 0x000B5F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321118, XrefRangeEnd = 321137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x000B7DC0 File Offset: 0x000B5FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321137, XrefRangeEnd = 321141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0000B3B7 File Offset: 0x000095B7
		public MemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000B7E0C File Offset: 0x000B600C
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0000B3C0 File Offset: 0x000095C0
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000B7E3C File Offset: 0x000B603C
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x0000B3DF File Offset: 0x000095DF
		public unsafe int _origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__origin)) = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000B7E64 File Offset: 0x000B6064
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x0000B3FA File Offset: 0x000095FA
		public unsafe int _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000B7E8C File Offset: 0x000B608C
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0000B415 File Offset: 0x00009615
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000B7EB4 File Offset: 0x000B60B4
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x0000B430 File Offset: 0x00009630
		public unsafe int _capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__capacity)) = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000B7EDC File Offset: 0x000B60DC
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0000B44B File Offset: 0x0000964B
		public unsafe bool _expandable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__expandable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__expandable)) = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000B7F04 File Offset: 0x000B6104
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0000B466 File Offset: 0x00009666
		public unsafe bool _writable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__writable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__writable)) = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000B7F2C File Offset: 0x000B612C
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000B481 File Offset: 0x00009681
		public unsafe bool _exposable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__exposable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__exposable)) = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000B7F54 File Offset: 0x000B6154
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x0000B49C File Offset: 0x0000969C
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000B7F7C File Offset: 0x000B617C
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x0000B4B7 File Offset: 0x000096B7
		public unsafe Task<int> _lastReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__lastReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryStream.NativeFieldInfoPtr__lastReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeFieldInfoPtr__origin;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr__capacity;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr__expandable;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeFieldInfoPtr__writable;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeFieldInfoPtr__exposable;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr__lastReadTask;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_EnsureWriteable_Private_Void_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Boolean_Int32_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetBuffer_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPosition_Internal_Int32_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadInt32_Internal_Int32_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_InternalEmulateRead_Internal_Int32_Int32_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;
	}
}
