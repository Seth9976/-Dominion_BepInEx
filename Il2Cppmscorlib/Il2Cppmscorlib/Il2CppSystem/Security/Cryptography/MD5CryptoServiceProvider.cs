using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000316 RID: 790
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x0600336B RID: 13163 RVA: 0x000FCD20 File Offset: 0x000FAF20
		// Note: this type is marked as 'beforefieldinit'.
		static MD5CryptoServiceProvider()
		{
			Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MD5CryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr);
			MD5CryptoServiceProvider.NativeFieldInfoPtr__H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_H");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "buff");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "count");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBuffer");
			MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "_ProcessingBufferCount");
			MD5CryptoServiceProvider.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, "K");
			MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671288);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671289);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671290);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671291);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671292);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671293);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671294);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671295);
			MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr, 100671296);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x000FCE7C File Offset: 0x000FB07C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341871, RefRangeEnd = 341875, XrefRangeStart = 341862, XrefRangeEnd = 341871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD5CryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD5CryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x000FCEB8 File Offset: 0x000FB0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341875, XrefRangeEnd = 341878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x000FCEEC File Offset: 0x000FB0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341878, XrefRangeEnd = 341882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x000FCF2C File Offset: 0x000FB12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341882, XrefRangeEnd = 341886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgb, int ibStart, int cbSize)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x000FCF8C File Offset: 0x000FB18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341886, XrefRangeEnd = 341890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x000FCFCC File Offset: 0x000FB1CC
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x000FD000 File Offset: 0x000FB200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341894, RefRangeEnd = 341898, XrefRangeStart = 341890, XrefRangeEnd = 341894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x000FD050 File Offset: 0x000FB250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341904, RefRangeEnd = 341905, XrefRangeStart = 341898, XrefRangeEnd = 341904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x000FD0B0 File Offset: 0x000FB2B0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD5CryptoServiceProvider.NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00012533 File Offset: 0x00010733
		public MD5CryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x000FD110 File Offset: 0x000FB310
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x0001253C File Offset: 0x0001073C
		public unsafe Il2CppStructArray<uint> _H
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__H), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06003378 RID: 13176 RVA: 0x000FD140 File Offset: 0x000FB340
		// (set) Token: 0x06003379 RID: 13177 RVA: 0x0001255B File Offset: 0x0001075B
		public unsafe Il2CppStructArray<uint> buff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_buff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x000FD170 File Offset: 0x000FB370
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x0001257A File Offset: 0x0001077A
		public unsafe ulong count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x000FD198 File Offset: 0x000FB398
		// (set) Token: 0x0600337D RID: 13181 RVA: 0x00012595 File Offset: 0x00010795
		public unsafe Il2CppStructArray<byte> _ProcessingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x000125B4 File Offset: 0x000107B4
		public unsafe int _ProcessingBufferCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MD5CryptoServiceProvider.NativeFieldInfoPtr__ProcessingBufferCount)) = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x000FD1F0 File Offset: 0x000FB3F0
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x000125CF File Offset: 0x000107CF
		public unsafe static Il2CppStructArray<uint> K
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MD5CryptoServiceProvider.NativeFieldInfoPtr_K, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeFieldInfoPtr__H;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeFieldInfoPtr_buff;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBuffer;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeFieldInfoPtr__ProcessingBufferCount;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFinalBlock_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeMethodInfoPtr_AddLength_Internal_Void_UInt64_Il2CppStructArray_1_Byte_Int32_0;
	}
}
