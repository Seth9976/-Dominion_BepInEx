using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200014B RID: 331
	[Serializable]
	public sealed class WeakReference<T> : Object where T : class
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x00089984 File Offset: 0x00087B84
		// Note: this type is marked as 'beforefieldinit'.
		static WeakReference()
		{
			Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WeakReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr);
			WeakReference<T>.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, "handle");
			WeakReference<T>.NativeFieldInfoPtr_trackResurrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, "trackResurrection");
			WeakReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667160);
			WeakReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667161);
			WeakReference<T>.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667162);
			WeakReference<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667163);
			WeakReference<T>.NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667164);
			WeakReference<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr, 100667165);
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00089A90 File Offset: 0x00087C90
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 309492, RefRangeEnd = 309502, XrefRangeStart = 309466, XrefRangeEnd = 309492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(T target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = target;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00089B14 File Offset: 0x00087D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309502, XrefRangeEnd = 309504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(T target, bool trackResurrection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = target;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackResurrection;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00089BA4 File Offset: 0x00087DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309504, XrefRangeEnd = 309516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00089C08 File Offset: 0x00087E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309516, XrefRangeEnd = 309531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00089C64 File Offset: 0x00087E64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309538, RefRangeEnd = 309541, XrefRangeStart = 309531, XrefRangeEnd = 309538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTarget(out T target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref target;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					target = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00089CF0 File Offset: 0x00087EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309541, XrefRangeEnd = 309544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00008228 File Offset: 0x00006428
		public WeakReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x00089D24 File Offset: 0x00087F24
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x00008231 File Offset: 0x00006431
		public unsafe GCHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference<T>.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference<T>.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00089D4C File Offset: 0x00087F4C
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0000824C File Offset: 0x0000644C
		public unsafe bool trackResurrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference<T>.NativeFieldInfoPtr_trackResurrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference<T>.NativeFieldInfoPtr_trackResurrection)) = value;
			}
		}

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeFieldInfoPtr_trackResurrection;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Boolean_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTarget_Public_Boolean_byref_T_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
