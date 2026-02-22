using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public class Object : Il2CppObjectBase
	{
		// Token: 0x0600156A RID: 5482 RVA: 0x00083784 File Offset: 0x00081984
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666941);
			Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666942);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666943);
			Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666944);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666945);
			Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666946);
			Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666947);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666948);
			Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666949);
			Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666950);
			Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666951);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00083890 File Offset: 0x00081A90
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000838E8 File Offset: 0x00081AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307419, RefRangeEnd = 307422, XrefRangeStart = 307419, XrefRangeEnd = 307419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(Object objA, Object objB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0008393C File Offset: 0x00081B3C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00083978 File Offset: 0x00081B78
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000839B4 File Offset: 0x00081BB4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 307423, RefRangeEnd = 307434, XrefRangeStart = 307422, XrefRangeEnd = 307423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000839FC File Offset: 0x00081BFC
		[CallerCount(323)]
		[CachedScanResults(RefRangeStart = 307435, RefRangeEnd = 307758, XrefRangeStart = 307434, XrefRangeEnd = 307435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetIl2CppType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00083A3C File Offset: 0x00081C3C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 307759, RefRangeEnd = 307793, XrefRangeStart = 307758, XrefRangeEnd = 307759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MemberwiseClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00083A7C File Offset: 0x00081C7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 307795, RefRangeEnd = 307799, XrefRangeStart = 307793, XrefRangeEnd = 307795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00083AC0 File Offset: 0x00081CC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 307423, RefRangeEnd = 307434, XrefRangeStart = 307423, XrefRangeEnd = 307434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalGetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00083B04 File Offset: 0x00081D04
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldGetter(string typeName, string fieldName, ref Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			val = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00083B80 File Offset: 0x00081D80
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FieldSetter(string typeName, string fieldName, Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00007734 File Offset: 0x00005934
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0000773D File Offset: 0x0000593D
		public static implicit operator Object(string A_0)
		{
			return A_0;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00083BE8 File Offset: 0x00081DE8
		public static implicit operator Object(sbyte value)
		{
			SByte @sbyte = default(SByte);
			@sbyte.m_value = value;
			return @sbyte.BoxIl2CppObject();
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00083C0C File Offset: 0x00081E0C
		public static implicit operator Object(byte value)
		{
			Byte @byte = default(Byte);
			@byte.m_value = value;
			return @byte.BoxIl2CppObject();
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00083C30 File Offset: 0x00081E30
		public static implicit operator Object(short value)
		{
			Int16 @int = default(Int16);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00083C54 File Offset: 0x00081E54
		public static implicit operator Object(ushort value)
		{
			UInt16 @uint = default(UInt16);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00083C78 File Offset: 0x00081E78
		public static implicit operator Object(int value)
		{
			Int32 @int = default(Int32);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00083C9C File Offset: 0x00081E9C
		public static implicit operator Object(uint value)
		{
			UInt32 @uint = default(UInt32);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00083CC0 File Offset: 0x00081EC0
		public static implicit operator Object(long value)
		{
			Int64 @int = default(Int64);
			@int.m_value = value;
			return @int.BoxIl2CppObject();
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00083CE4 File Offset: 0x00081EE4
		public static implicit operator Object(ulong value)
		{
			UInt64 @uint = default(UInt64);
			@uint.m_value = value;
			return @uint.BoxIl2CppObject();
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00083D08 File Offset: 0x00081F08
		public static implicit operator Object(float value)
		{
			Single single = default(Single);
			single.m_value = value;
			return single.BoxIl2CppObject();
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00083D2C File Offset: 0x00081F2C
		public static implicit operator Object(double value)
		{
			Double @double = default(Double);
			@double.m_value = value;
			return @double.BoxIl2CppObject();
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00083D50 File Offset: 0x00081F50
		public static implicit operator Object(char value)
		{
			Char @char = default(Char);
			@char.m_value = value;
			return @char.BoxIl2CppObject();
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00083D74 File Offset: 0x00081F74
		public static implicit operator Object(bool value)
		{
			Boolean boolean = default(Boolean);
			boolean.m_value = value;
			return boolean.BoxIl2CppObject();
		}

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_New_Void_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Type_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_MemberwiseClone_Protected_Object_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Static_Int32_Object_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_FieldGetter_Private_Void_String_String_byref_Object_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_FieldSetter_Private_Void_String_String_Object_0;
	}
}
