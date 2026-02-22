using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
[ObfuscatedName("<>f__AnonymousType0`1")]
public sealed class __f__AnonymousType0<_message_j__TPar> : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00022898 File Offset: 0x00020A98
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType0()
	{
		Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "", "<>f__AnonymousType0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_message_j__TPar>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr);
		__f__AnonymousType0<_message_j__TPar>.NativeFieldInfoPtr__message_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr, "<message>i__Field");
		__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__message_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr, 100663297);
		__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr, 100663298);
		__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr, 100663299);
		__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr, 100663300);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00022968 File Offset: 0x00020B68
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 258322, RefRangeEnd = 258324, XrefRangeStart = 258321, XrefRangeEnd = 258322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __f__AnonymousType0(_message_j__TPar message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType0<_message_j__TPar>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(_message_j__TPar).IsValueType)
			{
				_message_j__TPar message_j__TPar = message;
				intPtr = ((message_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(message_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(message_j__TPar as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref message;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__message_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000229EC File Offset: 0x00020BEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258324, XrefRangeEnd = 258326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00022A3C File Offset: 0x00020C3C
	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00022A78 File Offset: 0x00020C78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258326, XrefRangeEnd = 258339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_message_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	public __f__AnonymousType0(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00022AB0 File Offset: 0x00020CB0
	// (set) Token: 0x06000008 RID: 8 RVA: 0x00022AD8 File Offset: 0x00020CD8
	public unsafe _message_j__TPar _message_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_message_j__TPar>.NativeFieldInfoPtr__message_i__Field);
			return IL2CPP.PointerToValueGeneric<_message_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_message_j__TPar>.NativeFieldInfoPtr__message_i__Field);
			Type typeFromHandle = typeof(_message_j__TPar);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					IntPtr intPtr4;
					IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
					if (intPtr3 != 0)
					{
						intPtr4 = intPtr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
						{
							IntPtr intPtr5 = intPtr3;
							cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
							return;
						}
					}
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				*intPtr2 = value;
			}
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr__message_i__Field;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__message_j__TPar_0;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
