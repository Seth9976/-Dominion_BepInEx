using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000096 RID: 150
	public class AndroidJavaObjectWrapper : Object
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x00018D04 File Offset: 0x00016F04
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaObjectWrapper()
		{
			Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Utils", "AndroidJavaObjectWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr);
			AndroidJavaObjectWrapper.NativeFieldInfoPtr__androidJavaObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr, "<androidJavaObject>k__BackingField");
			AndroidJavaObjectWrapper.NativeMethodInfoPtr_get_androidJavaObject_Private_get_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr, 100663994);
			AndroidJavaObjectWrapper.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr, 100663995);
			AndroidJavaObjectWrapper.NativeMethodInfoPtr_Call_Public_Virtual_Final_New_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr, 100663996);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00018D84 File Offset: 0x00016F84
		public unsafe IDisposable androidJavaObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObjectWrapper.NativeMethodInfoPtr_get_androidJavaObject_Private_get_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObjectWrapper(AndroidJavaObject obj)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObjectWrapper.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00018E10 File Offset: 0x00017010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157390, XrefRangeEnd = 157416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ReturnType Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObjectWrapper.MethodInfoStoreGeneric_Call_Public_Virtual_Final_New_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00004E0C File Offset: 0x0000300C
		public virtual ReturnType Call<ReturnType>(string methodName, params Object[] args)
		{
			return this.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00004E1B File Offset: 0x0000301B
		public AndroidJavaObjectWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00018E7C File Offset: 0x0001707C
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00004E24 File Offset: 0x00003024
		public unsafe IDisposable _androidJavaObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObjectWrapper.NativeFieldInfoPtr__androidJavaObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObjectWrapper.NativeFieldInfoPtr__androidJavaObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr__androidJavaObject_k__BackingField;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_get_androidJavaObject_Private_get_IDisposable_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaObject_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Virtual_Final_New_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x020000CA RID: 202
		private sealed class MethodInfoStoreGeneric_Call_Public_Virtual_Final_New_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x040004B1 RID: 1201
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObjectWrapper.NativeMethodInfoPtr_Call_Public_Virtual_Final_New_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObjectWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}
	}
}
