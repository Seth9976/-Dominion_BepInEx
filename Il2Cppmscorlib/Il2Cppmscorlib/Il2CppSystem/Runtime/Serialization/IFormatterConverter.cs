using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032C RID: 812
	public class IFormatterConverter : Il2CppObjectBase
	{
		// Token: 0x0600347B RID: 13435 RVA: 0x00100DE0 File Offset: 0x000FEFE0
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatterConverter()
		{
			Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IFormatterConverter");
			IFormatterConverter.NativeMethodInfoPtr_Convert_Public_Abstract_Virtual_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671437);
			IFormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671438);
			IFormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671439);
			IFormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671440);
			IFormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671441);
			IFormatterConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatterConverter>.NativeClassPtr, 100671442);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00100E80 File Offset: 0x000FF080
		[CallerCount(0)]
		public unsafe virtual Object Convert(Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_Convert_Public_Abstract_Virtual_New_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00100EF0 File Offset: 0x000FF0F0
		[CallerCount(0)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00100F48 File Offset: 0x000FF148
		[CallerCount(0)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00100FA0 File Offset: 0x000FF1A0
		[CallerCount(0)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00100FF8 File Offset: 0x000FF1F8
		[CallerCount(0)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00101050 File Offset: 0x000FF250
		[CallerCount(0)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatterConverter.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00012B3C File Offset: 0x00010D3C
		public IFormatterConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Abstract_Virtual_New_Object_Object_Type_0;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Abstract_Virtual_New_Int32_Object_0;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Abstract_Virtual_New_Int64_Object_0;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Abstract_Virtual_New_Single_Object_0;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Object_0;
	}
}
