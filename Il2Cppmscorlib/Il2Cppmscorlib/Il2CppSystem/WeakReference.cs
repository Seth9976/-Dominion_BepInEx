using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200014A RID: 330
	[Serializable]
	public class WeakReference : Object
	{
		// Token: 0x060016FE RID: 5886 RVA: 0x000894A8 File Offset: 0x000876A8
		// Note: this type is marked as 'beforefieldinit'.
		static WeakReference()
		{
			Il2CppClassPointerStore<WeakReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WeakReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakReference>.NativeClassPtr);
			WeakReference.NativeFieldInfoPtr_isLongReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, "isLongReference");
			WeakReference.NativeFieldInfoPtr_gcHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, "gcHandle");
			WeakReference.NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667149);
			WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667150);
			WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667151);
			WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667152);
			WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667153);
			WeakReference.NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667154);
			WeakReference.NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667155);
			WeakReference.NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667156);
			WeakReference.NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667157);
			WeakReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667158);
			WeakReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667159);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x000895DC File Offset: 0x000877DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309426, XrefRangeEnd = 309427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateHandle(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00089620 File Offset: 0x00087820
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0008965C File Offset: 0x0008785C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 309429, RefRangeEnd = 309434, XrefRangeStart = 309427, XrefRangeEnd = 309429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(Object target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000896A8 File Offset: 0x000878A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309434, XrefRangeEnd = 309436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(Object target, bool trackResurrection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackResurrection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00089704 File Offset: 0x00087904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309436, XrefRangeEnd = 309450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x00089768 File Offset: 0x00087968
		public unsafe virtual bool IsAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x000897B0 File Offset: 0x000879B0
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x000897FC File Offset: 0x000879FC
		public unsafe virtual Object Target
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309450, XrefRangeEnd = 309452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309452, XrefRangeEnd = 309453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0008984C File Offset: 0x00087A4C
		public unsafe virtual bool TrackResurrection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00089894 File Offset: 0x00087A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309453, XrefRangeEnd = 309457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000898D0 File Offset: 0x00087AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309457, XrefRangeEnd = 309466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000081E9 File Offset: 0x000063E9
		public WeakReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00089934 File Offset: 0x00087B34
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x000081F2 File Offset: 0x000063F2
		public unsafe bool isLongReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_isLongReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_isLongReference)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0008995C File Offset: 0x00087B5C
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000820D File Offset: 0x0000640D
		public unsafe GCHandle gcHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_gcHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_gcHandle)) = value;
			}
		}

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeFieldInfoPtr_isLongReference;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeFieldInfoPtr_gcHandle;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;
	}
}
