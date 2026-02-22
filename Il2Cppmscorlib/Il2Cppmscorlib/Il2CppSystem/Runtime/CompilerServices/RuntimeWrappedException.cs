using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041F RID: 1055
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x060041E0 RID: 16864 RVA: 0x0012FF84 File Offset: 0x0012E184
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeWrappedException()
		{
			Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeWrappedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr);
			RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, "m_wrappedException");
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100672883);
			RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100672884);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100672885);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100672886);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00130018 File Offset: 0x0012E218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356822, XrefRangeEnd = 356830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(Object thrownObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thrownObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00130064 File Offset: 0x0012E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356830, XrefRangeEnd = 356840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x001300C0 File Offset: 0x0012E2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356840, XrefRangeEnd = 356853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00130124 File Offset: 0x0012E324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356853, XrefRangeEnd = 356856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x000191C0 File Offset: 0x000173C0
		public RuntimeWrappedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x00130160 File Offset: 0x0012E360
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x000191C9 File Offset: 0x000173C9
		public unsafe Object m_wrappedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_m_wrappedException;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
