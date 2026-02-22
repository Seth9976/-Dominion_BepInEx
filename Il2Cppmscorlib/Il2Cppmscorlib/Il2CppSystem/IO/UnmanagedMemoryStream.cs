using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000210 RID: 528
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x06002253 RID: 8787 RVA: 0x000BC410 File Offset: 0x000BA610
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedMemoryStream()
		{
			Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "UnmanagedMemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr);
			UnmanagedMemoryStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_buffer");
			UnmanagedMemoryStream.NativeFieldInfoPtr__mem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_mem");
			UnmanagedMemoryStream.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_length");
			UnmanagedMemoryStream.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_capacity");
			UnmanagedMemoryStream.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_position");
			UnmanagedMemoryStream.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_offset");
			UnmanagedMemoryStream.NativeFieldInfoPtr__access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_access");
			UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_isOpen");
			UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, "_lastReadTask");
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669053);
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669054);
			UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669055);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Initialize_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669056);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669057);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669058);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669059);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669060);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669061);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669062);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669063);
			UnmanagedMemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669064);
			UnmanagedMemoryStream.NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669065);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669066);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669067);
			UnmanagedMemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669068);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669069);
			UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669070);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669071);
			UnmanagedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr, 100669072);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000BC684 File Offset: 0x000BA884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322272, RefRangeEnd = 322273, XrefRangeStart = 322268, XrefRangeEnd = 322272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000BC6C0 File Offset: 0x000BA8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322278, RefRangeEnd = 322279, XrefRangeStart = 322273, XrefRangeEnd = 322278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000BC714 File Offset: 0x000BA914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322279, XrefRangeEnd = 322284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMemoryStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000BC794 File Offset: 0x000BA994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322284, RefRangeEnd = 322287, XrefRangeStart = 322284, XrefRangeEnd = 322284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipSecurityCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_Initialize_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000BC80C File Offset: 0x000BAA0C
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000BC854 File Offset: 0x000BAA54
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000BC89C File Offset: 0x000BAA9C
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000BC8E4 File Offset: 0x000BAAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322288, RefRangeEnd = 322290, XrefRangeStart = 322287, XrefRangeEnd = 322288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000BC930 File Offset: 0x000BAB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322290, XrefRangeEnd = 322291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000BC96C File Offset: 0x000BAB6C
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322291, XrefRangeEnd = 322293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x000BC9B4 File Offset: 0x000BABB4
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x000BC9FC File Offset: 0x000BABFC
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322293, XrefRangeEnd = 322295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322295, XrefRangeEnd = 322305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000BCA48 File Offset: 0x000BAC48
		public unsafe byte* PositionPointer
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 322307, RefRangeEnd = 322312, XrefRangeStart = 322305, XrefRangeEnd = 322307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMemoryStream.NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000BCA7C File Offset: 0x000BAC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322312, XrefRangeEnd = 322323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x000BCB04 File Offset: 0x000BAD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322323, XrefRangeEnd = 322341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000BCB94 File Offset: 0x000BAD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322341, XrefRangeEnd = 322350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000BCBDC File Offset: 0x000BADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322350, XrefRangeEnd = 322385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000BCC40 File Offset: 0x000BAE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322385, XrefRangeEnd = 322398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000BCCAC File Offset: 0x000BAEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322398, XrefRangeEnd = 322410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000BCD3C File Offset: 0x000BAF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322410, XrefRangeEnd = 322421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnmanagedMemoryStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0000BA44 File Offset: 0x00009C44
		public UnmanagedMemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x000BCD88 File Offset: 0x000BAF88
		// (set) Token: 0x0600226A RID: 8810 RVA: 0x0000BA4D File Offset: 0x00009C4D
		public unsafe SafeBuffer _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000BCDB8 File Offset: 0x000BAFB8
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x0000BA6C File Offset: 0x00009C6C
		public unsafe byte* _mem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__mem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__mem)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000BCDDC File Offset: 0x000BAFDC
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x0000BA87 File Offset: 0x00009C87
		public unsafe long _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x000BCE04 File Offset: 0x000BB004
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x0000BAA2 File Offset: 0x00009CA2
		public unsafe long _capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__capacity)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x000BCE2C File Offset: 0x000BB02C
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x0000BABD File Offset: 0x00009CBD
		public unsafe long _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x000BCE54 File Offset: 0x000BB054
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		public unsafe long _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x000BCE7C File Offset: 0x000BB07C
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x0000BAF3 File Offset: 0x00009CF3
		public unsafe FileAccess _access
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__access);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__access)) = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x000BCEA4 File Offset: 0x000BB0A4
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x0000BB0E File Offset: 0x00009D0E
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000BCECC File Offset: 0x000BB0CC
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0000BB29 File Offset: 0x00009D29
		public unsafe Task<int> _lastReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedMemoryStream.NativeFieldInfoPtr__lastReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeFieldInfoPtr__mem;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr__capacity;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr__access;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeFieldInfoPtr__lastReadTask;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_Int64_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_ptr_Byte_Int64_Int64_FileAccess_Boolean_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionPointer_Public_get_ptr_Byte_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;
	}
}
