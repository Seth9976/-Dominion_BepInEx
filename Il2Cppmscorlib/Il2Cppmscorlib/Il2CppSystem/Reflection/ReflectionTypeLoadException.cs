using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B8 RID: 440
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x000A0E9C File Offset: 0x0009F09C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionTypeLoadException()
		{
			Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ReflectionTypeLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr);
			ReflectionTypeLoadException.NativeFieldInfoPtr__classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "_classes");
			ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "_exceptions");
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668007);
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668008);
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668009);
			ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668010);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x000A0F44 File Offset: 0x0009F144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317285, XrefRangeEnd = 317290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000A0F80 File Offset: 0x0009F180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317290, XrefRangeEnd = 317292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(Il2CppReferenceArray<Type> classes, Il2CppReferenceArray<Exception> exceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000A0FE0 File Offset: 0x0009F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317292, XrefRangeEnd = 317315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000A1044 File Offset: 0x0009F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317315, XrefRangeEnd = 317331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00009BAB File Offset: 0x00007DAB
		public ReflectionTypeLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00009BB4 File Offset: 0x00007DB4
		public unsafe Il2CppReferenceArray<Type> _classes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__classes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__classes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000A10D0 File Offset: 0x0009F2D0
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00009BD3 File Offset: 0x00007DD3
		public unsafe Il2CppReferenceArray<Exception> _exceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr__classes;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr__exceptions;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
