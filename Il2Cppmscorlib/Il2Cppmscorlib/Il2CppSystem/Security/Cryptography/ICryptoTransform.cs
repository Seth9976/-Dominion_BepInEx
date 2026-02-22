using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002EF RID: 751
	public class ICryptoTransform : Il2CppObjectBase
	{
		// Token: 0x06003130 RID: 12592 RVA: 0x000F4B68 File Offset: 0x000F2D68
		// Note: this type is marked as 'beforefieldinit'.
		static ICryptoTransform()
		{
			Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "ICryptoTransform");
			ICryptoTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr, 100671018);
			ICryptoTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr, 100671019);
			ICryptoTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr, 100671020);
			ICryptoTransform.NativeMethodInfoPtr_TransformBlock_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr, 100671021);
			ICryptoTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICryptoTransform>.NativeClassPtr, 100671022);
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x000F4BF4 File Offset: 0x000F2DF4
		public unsafe virtual int InputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICryptoTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x000F4C3C File Offset: 0x000F2E3C
		public unsafe virtual int OutputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICryptoTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x000F4C84 File Offset: 0x000F2E84
		public unsafe virtual bool CanTransformMultipleBlocks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICryptoTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000F4CCC File Offset: 0x000F2ECC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICryptoTransform.NativeMethodInfoPtr_TransformBlock_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000F4D64 File Offset: 0x000F2F64
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICryptoTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000116AD File Offset: 0x0000F8AD
		public ICryptoTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
