using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B6 RID: 438
	[Serializable]
	public sealed class Pointer : Object
	{
		// Token: 0x06001C30 RID: 7216 RVA: 0x000A0C50 File Offset: 0x0009EE50
		// Note: this type is marked as 'beforefieldinit'.
		static Pointer()
		{
			Il2CppClassPointerStore<Pointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Pointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pointer>.NativeClassPtr);
			Pointer.NativeFieldInfoPtr__ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pointer>.NativeClassPtr, "_ptr");
			Pointer.NativeFieldInfoPtr__ptrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pointer>.NativeClassPtr, "_ptrType");
			Pointer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100668003);
			Pointer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100668004);
			Pointer.NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100668005);
			Pointer.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pointer>.NativeClassPtr, 100668006);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000A0CF8 File Offset: 0x0009EEF8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pointer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pointer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000A0D34 File Offset: 0x0009EF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317241, XrefRangeEnd = 317262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pointer(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pointer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x000A0D98 File Offset: 0x0009EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317262, XrefRangeEnd = 317276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Box(void* ptr, Type type)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x000A0DEC File Offset: 0x0009EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317276, XrefRangeEnd = 317285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pointer.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00009B68 File Offset: 0x00007D68
		public Pointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000A0E48 File Offset: 0x0009F048
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00009B71 File Offset: 0x00007D71
		public unsafe void* _ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptr)) = value;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000A0E6C File Offset: 0x0009F06C
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00009B8C File Offset: 0x00007D8C
		public unsafe RuntimeType _ptrType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptrType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pointer.NativeFieldInfoPtr__ptrType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr__ptr;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr__ptrType;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_Object_ptr_Void_Type_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
