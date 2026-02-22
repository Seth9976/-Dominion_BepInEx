using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E7 RID: 743
	public class HashAlgorithm : Object
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x000F3710 File Offset: 0x000F1910
		// Note: this type is marked as 'beforefieldinit'.
		static HashAlgorithm()
		{
			Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "HashAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr);
			HashAlgorithm.NativeFieldInfoPtr_HashSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "HashSizeValue");
			HashAlgorithm.NativeFieldInfoPtr_HashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "HashValue");
			HashAlgorithm.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "State");
			HashAlgorithm.NativeFieldInfoPtr_m_bDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, "m_bDisposed");
			HashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670975);
			HashAlgorithm.NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670976);
			HashAlgorithm.NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670977);
			HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670978);
			HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670979);
			HashAlgorithm.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670980);
			HashAlgorithm.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670981);
			HashAlgorithm.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670982);
			HashAlgorithm.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670983);
			HashAlgorithm.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670984);
			HashAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670985);
			HashAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670986);
			HashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670987);
			HashAlgorithm.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670988);
			HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670989);
			HashAlgorithm.NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr, 100670990);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000F38D0 File Offset: 0x000F1AD0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x000F390C File Offset: 0x000F1B0C
		public unsafe virtual int HashSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x000F3954 File Offset: 0x000F1B54
		public unsafe virtual Il2CppStructArray<byte> Hash
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339475, XrefRangeEnd = 339478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000F39A0 File Offset: 0x000F1BA0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 339481, RefRangeEnd = 339500, XrefRangeStart = 339478, XrefRangeEnd = 339481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputeHash(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000F39F0 File Offset: 0x000F1BF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 339504, RefRangeEnd = 339508, XrefRangeStart = 339500, XrefRangeEnd = 339504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ComputeHash(Il2CppStructArray<byte> buffer, int offset, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000F3A5C File Offset: 0x000F1C5C
		public unsafe virtual int InputBlockSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x000F3AA4 File Offset: 0x000F1CA4
		public unsafe virtual int OutputBlockSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000F3AEC File Offset: 0x000F1CEC
		public unsafe virtual bool CanTransformMultipleBlocks
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000F3B34 File Offset: 0x000F1D34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 339510, RefRangeEnd = 339517, XrefRangeStart = 339508, XrefRangeEnd = 339510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000F3BC0 File Offset: 0x000F1DC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 339527, RefRangeEnd = 339531, XrefRangeStart = 339517, XrefRangeEnd = 339527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000F3C2C File Offset: 0x000F1E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339531, XrefRangeEnd = 339535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000F3C60 File Offset: 0x000F1E60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339538, RefRangeEnd = 339540, XrefRangeStart = 339535, XrefRangeEnd = 339538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000F3C94 File Offset: 0x000F1E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 339541, RefRangeEnd = 339543, XrefRangeStart = 339540, XrefRangeEnd = 339541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000F3CE0 File Offset: 0x000F1EE0
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000F3D1C File Offset: 0x000F1F1C
		[CallerCount(0)]
		public unsafe virtual void HashCore(Il2CppStructArray<byte> array, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000F3D88 File Offset: 0x000F1F88
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashAlgorithm.NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000114EE File Offset: 0x0000F6EE
		public HashAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x000F3DD4 File Offset: 0x000F1FD4
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x000114F7 File Offset: 0x0000F6F7
		public unsafe int HashSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashSizeValue)) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x000F3DFC File Offset: 0x000F1FFC
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00011512 File Offset: 0x0000F712
		public unsafe Il2CppStructArray<byte> HashValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_HashValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000F3E2C File Offset: 0x000F202C
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x00011531 File Offset: 0x0000F731
		public unsafe int State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000F3E54 File Offset: 0x000F2054
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x0001154C File Offset: 0x0000F74C
		public unsafe bool m_bDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_m_bDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashAlgorithm.NativeFieldInfoPtr_m_bDisposed)) = value;
			}
		}

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeValue;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeFieldInfoPtr_HashValue;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeFieldInfoPtr_m_bDisposed;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr_get_HashSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_get_Hash_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Public_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
