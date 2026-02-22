using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000328 RID: 808
	public class FormatterConverter : Object
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x001000E0 File Offset: 0x000FE2E0
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterConverter()
		{
			Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FormatterConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr);
			FormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671405);
			FormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671406);
			FormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671407);
			FormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671408);
			FormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671409);
			FormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671410);
			FormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr, 100671411);
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x0010019C File Offset: 0x000FE39C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatterConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x001001D8 File Offset: 0x000FE3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342392, XrefRangeEnd = 342406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x0010023C File Offset: 0x000FE43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342406, XrefRangeEnd = 342420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x0010028C File Offset: 0x000FE48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342420, XrefRangeEnd = 342434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x001002DC File Offset: 0x000FE4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342434, XrefRangeEnd = 342448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x0010032C File Offset: 0x000FE52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342448, XrefRangeEnd = 342462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x0010037C File Offset: 0x000FE57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342462, XrefRangeEnd = 342476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterConverter.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00012A78 File Offset: 0x00010C78
		public FormatterConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Object_Object_Type_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Final_New_Int64_Object_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Final_New_Single_Object_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_Object_0;
	}
}
