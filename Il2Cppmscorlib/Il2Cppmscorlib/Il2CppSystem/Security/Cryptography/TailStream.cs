using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F2 RID: 754
	public sealed class TailStream : Stream
	{
		// Token: 0x06003150 RID: 12624 RVA: 0x000F5320 File Offset: 0x000F3520
		// Note: this type is marked as 'beforefieldinit'.
		static TailStream()
		{
			Il2CppClassPointerStore<TailStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TailStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TailStream>.NativeClassPtr);
			TailStream.NativeFieldInfoPtr__Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailStream>.NativeClassPtr, "_Buffer");
			TailStream.NativeFieldInfoPtr__BufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailStream>.NativeClassPtr, "_BufferSize");
			TailStream.NativeFieldInfoPtr__BufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailStream>.NativeClassPtr, "_BufferIndex");
			TailStream.NativeFieldInfoPtr__BufferFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailStream>.NativeClassPtr, "_BufferFull");
			TailStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671032);
			TailStream.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671033);
			TailStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671034);
			TailStream.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671035);
			TailStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671036);
			TailStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671037);
			TailStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671038);
			TailStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671039);
			TailStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671040);
			TailStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671041);
			TailStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671042);
			TailStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671043);
			TailStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671044);
			TailStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailStream>.NativeClassPtr, 100671045);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000F54B8 File Offset: 0x000F36B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339836, RefRangeEnd = 339838, XrefRangeStart = 339829, XrefRangeEnd = 339836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TailStream(int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TailStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000F5500 File Offset: 0x000F3700
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 321373, RefRangeEnd = 321379, XrefRangeStart = 321373, XrefRangeEnd = 321379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000F5534 File Offset: 0x000F3734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339838, XrefRangeEnd = 339842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x000F5574 File Offset: 0x000F3774
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 339845, RefRangeEnd = 339846, XrefRangeStart = 339842, XrefRangeEnd = 339845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x000F55B4 File Offset: 0x000F37B4
		public unsafe override bool CanRead
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x000F55F0 File Offset: 0x000F37F0
		public unsafe override bool CanSeek
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x000F562C File Offset: 0x000F382C
		public unsafe override bool CanWrite
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254450, RefRangeEnd = 254451, XrefRangeStart = 254450, XrefRangeEnd = 254451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x000F5668 File Offset: 0x000F3868
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339846, XrefRangeEnd = 339853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x000F56A4 File Offset: 0x000F38A4
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x000F56E0 File Offset: 0x000F38E0
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339853, XrefRangeEnd = 339860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339860, XrefRangeEnd = 339867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000F5720 File Offset: 0x000F3920
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000F5754 File Offset: 0x000F3954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339867, XrefRangeEnd = 339874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000F57AC File Offset: 0x000F39AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339874, XrefRangeEnd = 339881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000F5818 File Offset: 0x000F3A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339881, XrefRangeEnd = 339890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0001177E File Offset: 0x0000F97E
		public TailStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000F5878 File Offset: 0x000F3A78
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x00011787 File Offset: 0x0000F987
		public unsafe Il2CppStructArray<byte> _Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x000F58A8 File Offset: 0x000F3AA8
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x000117A6 File Offset: 0x0000F9A6
		public unsafe int _BufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferSize)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x000F58D0 File Offset: 0x000F3AD0
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x000117C1 File Offset: 0x0000F9C1
		public unsafe int _BufferIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferIndex)) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x000F58F8 File Offset: 0x000F3AF8
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x000117DC File Offset: 0x0000F9DC
		public unsafe bool _BufferFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferFull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailStream.NativeFieldInfoPtr__BufferFull)) = value;
			}
		}

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeFieldInfoPtr__Buffer;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeFieldInfoPtr__BufferSize;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeFieldInfoPtr__BufferIndex;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeFieldInfoPtr__BufferFull;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
