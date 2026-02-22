using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200031B RID: 795
	public class SHA1Internal : Object
	{
		// Token: 0x060033A9 RID: 13225 RVA: 0x000FD8E8 File Offset: 0x000FBAE8
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1Internal()
		{
			Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr);
			SHA1Internal.NativeFieldInfoPtr__H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_H");
			SHA1Internal.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "count");
			SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_ProcessingBuffer");
			SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "_ProcessingBufferCount");
			SHA1Internal.NativeFieldInfoPtr_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, "buff");
			SHA1Internal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671313);
			SHA1Internal.NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671314);
			SHA1Internal.NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671315);
			SHA1Internal.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671316);
			SHA1Internal.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671317);
			SHA1Internal.NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671318);
			SHA1Internal.NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671319);
			SHA1Internal.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671320);
			SHA1Internal.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr, 100671321);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000FDA30 File Offset: 0x000FBC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341979, XrefRangeEnd = 341989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1Internal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1Internal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000FDA6C File Offset: 0x000FBC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341989, XrefRangeEnd = 341993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000FDACC File Offset: 0x000FBCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341993, XrefRangeEnd = 341997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000FDB0C File Offset: 0x000FBD0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341997, RefRangeEnd = 342001, XrefRangeStart = 341997, XrefRangeEnd = 341997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000FDB40 File Offset: 0x000FBD40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 342003, RefRangeEnd = 342009, XrefRangeStart = 342001, XrefRangeEnd = 342003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> inputBuffer, uint inputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000FDB90 File Offset: 0x000FBD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342009, RefRangeEnd = 342010, XrefRangeStart = 342009, XrefRangeEnd = 342009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitialiseBuff(Il2CppStructArray<uint> buff, Il2CppStructArray<byte> input, uint inputOffset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buff);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000FDBE8 File Offset: 0x000FBDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342010, RefRangeEnd = 342011, XrefRangeStart = 342010, XrefRangeEnd = 342010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillBuff(Il2CppStructArray<uint> buff)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000FDC20 File Offset: 0x000FBE20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342018, RefRangeEnd = 342020, XrefRangeStart = 342011, XrefRangeEnd = 342018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000FDC80 File Offset: 0x000FBE80
		[CallerCount(0)]
		public unsafe void AddLength(ulong length, Il2CppStructArray<byte> buffer, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1Internal.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0001275C File Offset: 0x0001095C
		public SHA1Internal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000FDCE0 File Offset: 0x000FBEE0
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x00012765 File Offset: 0x00010965
		public unsafe Il2CppStructArray<uint> _H
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__H);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__H), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x000FDD10 File Offset: 0x000FBF10
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x00012784 File Offset: 0x00010984
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x000FDD38 File Offset: 0x000FBF38
		// (set) Token: 0x060033B9 RID: 13241 RVA: 0x0001279F File Offset: 0x0001099F
		public unsafe Il2CppStructArray<byte> _ProcessingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x000FDD68 File Offset: 0x000FBF68
		// (set) Token: 0x060033BB RID: 13243 RVA: 0x000127BE File Offset: 0x000109BE
		public unsafe int _ProcessingBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr__ProcessingBufferCount)) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x000FDD90 File Offset: 0x000FBF90
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x000127D9 File Offset: 0x000109D9
		public unsafe Il2CppStructArray<uint> buff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_buff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SHA1Internal.NativeFieldInfoPtr_buff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeFieldInfoPtr__H;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBuffer;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBufferCount;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeFieldInfoPtr_buff;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_FillBuff_Private_Static_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0;
	}
}
