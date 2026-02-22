using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class AndroidJavaProxy : Object
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002E6C File Offset: 0x0000106C
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaProxy()
		{
			Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr);
			AndroidJavaProxy.NativeFieldInfoPtr_javaInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "javaInterface");
			AndroidJavaProxy.NativeFieldInfoPtr_proxyObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "proxyObject");
			AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "s_JavaLangSystemClass");
			AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "s_HashCodeMethodID");
			AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663306);
			AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663307);
			AndroidJavaProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663308);
			AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663309);
			AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663310);
			AndroidJavaProxy.NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663311);
			AndroidJavaProxy.NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002F78 File Offset: 0x00001178
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 127399, RefRangeEnd = 127412, XrefRangeStart = 127393, XrefRangeEnd = 127399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaProxy(string javaInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(javaInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002FC4 File Offset: 0x000011C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127412, XrefRangeEnd = 127414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaProxy(AndroidJavaClass javaInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(javaInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003010 File Offset: 0x00001210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127414, XrefRangeEnd = 127421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000304C File Offset: 0x0000124C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127421, XrefRangeEnd = 127482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject Invoke(string methodName, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000030BC File Offset: 0x000012BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127482, XrefRangeEnd = 127518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject Invoke(string methodName, Il2CppReferenceArray<AndroidJavaObject> javaArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(javaArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000312C File Offset: 0x0000132C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127518, XrefRangeEnd = 127523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject GetProxyObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000316C File Offset: 0x0000136C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 127534, RefRangeEnd = 127538, XrefRangeStart = 127523, XrefRangeEnd = 127534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetRawProxy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000211E File Offset: 0x0000031E
		public AndroidJavaProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000031A8 File Offset: 0x000013A8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002127 File Offset: 0x00000327
		public unsafe AndroidJavaClass javaInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_javaInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_javaInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000031D8 File Offset: 0x000013D8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe IntPtr proxyObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_proxyObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_proxyObject)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003200 File Offset: 0x00001400
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002161 File Offset: 0x00000361
		public unsafe static GlobalJavaObjectRef s_JavaLangSystemClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002173 File Offset: 0x00000373
		public unsafe static IntPtr s_HashCodeMethodID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID, (void*)(&value));
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003244 File Offset: 0x00001444
		public virtual bool equals(AndroidJavaObject obj)
		{
			IntPtr intPtr = ((obj == null) ? IntPtr.Zero : obj.GetRawObject());
			return AndroidJNI.IsSameObject(this.proxyObject, intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002181 File Offset: 0x00000381
		public virtual int hashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003274 File Offset: 0x00001474
		public virtual string toString()
		{
			return String.Concat((this != null) ? this.ToString() : null, " <c# proxy java object>");
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_javaInterface;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_proxyObject;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_s_JavaLangSystemClass;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_s_HashCodeMethodID;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0;
	}
}
