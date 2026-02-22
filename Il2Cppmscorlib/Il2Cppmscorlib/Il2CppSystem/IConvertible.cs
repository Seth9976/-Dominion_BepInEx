using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000BA RID: 186
	public class IConvertible : Il2CppObjectBase
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x0005CAE0 File Offset: 0x0005ACE0
		// Note: this type is marked as 'beforefieldinit'.
		static IConvertible()
		{
			Il2CppClassPointerStore<IConvertible>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IConvertible");
			IConvertible.NativeMethodInfoPtr_GetTypeCode_Public_Abstract_Virtual_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665459);
			IConvertible.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665460);
			IConvertible.NativeMethodInfoPtr_ToChar_Public_Abstract_Virtual_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665461);
			IConvertible.NativeMethodInfoPtr_ToSByte_Public_Abstract_Virtual_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665462);
			IConvertible.NativeMethodInfoPtr_ToByte_Public_Abstract_Virtual_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665463);
			IConvertible.NativeMethodInfoPtr_ToInt16_Public_Abstract_Virtual_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665464);
			IConvertible.NativeMethodInfoPtr_ToUInt16_Public_Abstract_Virtual_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665465);
			IConvertible.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665466);
			IConvertible.NativeMethodInfoPtr_ToUInt32_Public_Abstract_Virtual_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665467);
			IConvertible.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665468);
			IConvertible.NativeMethodInfoPtr_ToUInt64_Public_Abstract_Virtual_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665469);
			IConvertible.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665470);
			IConvertible.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665471);
			IConvertible.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665472);
			IConvertible.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665473);
			IConvertible.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665474);
			IConvertible.NativeMethodInfoPtr_ToType_Public_Abstract_Virtual_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConvertible>.NativeClassPtr, 100665475);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0005CC5C File Offset: 0x0005AE5C
		[CallerCount(0)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_GetTypeCode_Public_Abstract_Virtual_New_TypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0005CCA4 File Offset: 0x0005AEA4
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0005CCFC File Offset: 0x0005AEFC
		[CallerCount(0)]
		public unsafe virtual char ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToChar_Public_Abstract_Virtual_New_Char_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0005CD54 File Offset: 0x0005AF54
		[CallerCount(0)]
		public unsafe virtual sbyte ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToSByte_Public_Abstract_Virtual_New_SByte_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0005CDAC File Offset: 0x0005AFAC
		[CallerCount(0)]
		public unsafe virtual byte ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToByte_Public_Abstract_Virtual_New_Byte_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0005CE04 File Offset: 0x0005B004
		[CallerCount(0)]
		public unsafe virtual short ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToInt16_Public_Abstract_Virtual_New_Int16_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0005CE5C File Offset: 0x0005B05C
		[CallerCount(0)]
		public unsafe virtual ushort ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToUInt16_Public_Abstract_Virtual_New_UInt16_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
		[CallerCount(0)]
		public unsafe virtual int ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0005CF0C File Offset: 0x0005B10C
		[CallerCount(0)]
		public unsafe virtual uint ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToUInt32_Public_Abstract_Virtual_New_UInt32_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0005CF64 File Offset: 0x0005B164
		[CallerCount(0)]
		public unsafe virtual long ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0005CFBC File Offset: 0x0005B1BC
		[CallerCount(0)]
		public unsafe virtual ulong ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToUInt64_Public_Abstract_Virtual_New_UInt64_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0005D014 File Offset: 0x0005B214
		[CallerCount(0)]
		public unsafe virtual float ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0005D06C File Offset: 0x0005B26C
		[CallerCount(0)]
		public unsafe virtual double ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
		[CallerCount(0)]
		public unsafe virtual Decimal ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0005D11C File Offset: 0x0005B31C
		[CallerCount(0)]
		public unsafe virtual DateTime ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0005D174 File Offset: 0x0005B374
		[CallerCount(0)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0005D1C8 File Offset: 0x0005B3C8
		[CallerCount(0)]
		public unsafe virtual Object ToType(Type conversionType, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConvertible.NativeMethodInfoPtr_ToType_Public_Abstract_Virtual_New_Object_Type_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000056E5 File Offset: 0x000038E5
		public IConvertible(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Abstract_Virtual_New_TypeCode_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_IFormatProvider_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Abstract_Virtual_New_Char_IFormatProvider_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Abstract_Virtual_New_SByte_IFormatProvider_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Abstract_Virtual_New_Byte_IFormatProvider_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Abstract_Virtual_New_Int16_IFormatProvider_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Abstract_Virtual_New_UInt16_IFormatProvider_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_IFormatProvider_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Abstract_Virtual_New_UInt32_IFormatProvider_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_IFormatProvider_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Abstract_Virtual_New_UInt64_IFormatProvider_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_IFormatProvider_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Abstract_Virtual_New_Double_IFormatProvider_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Abstract_Virtual_New_Decimal_IFormatProvider_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Abstract_Virtual_New_DateTime_IFormatProvider_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_IFormatProvider_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Public_Abstract_Virtual_New_Object_Type_IFormatProvider_0;
	}
}
