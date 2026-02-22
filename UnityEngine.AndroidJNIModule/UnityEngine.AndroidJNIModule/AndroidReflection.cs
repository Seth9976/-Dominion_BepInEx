using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class AndroidReflection : Object
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00004858 File Offset: 0x00002A58
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidReflection()
		{
			Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidReflection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr);
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperClass");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetConstructorID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetMethodID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldSignature");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperNewProxyInstance");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperSetNativeExceptionOnProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperSetNativeExceptionOnProxy");
			AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_FieldGetDeclaringClass");
			AndroidReflection.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663340);
			AndroidReflection.NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663341);
			AndroidReflection.NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663342);
			AndroidReflection.NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663343);
			AndroidReflection.NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663344);
			AndroidReflection.NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663345);
			AndroidReflection.NativeMethodInfoPtr_GetFieldMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663346);
			AndroidReflection.NativeMethodInfoPtr_GetFieldClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663347);
			AndroidReflection.NativeMethodInfoPtr_GetFieldSignature_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663348);
			AndroidReflection.NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663349);
			AndroidReflection.NativeMethodInfoPtr_SetNativeExceptionOnProxy_Public_Static_Void_IntPtr_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663350);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004A04 File Offset: 0x00002C04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 128391, RefRangeEnd = 128396, XrefRangeStart = 128389, XrefRangeEnd = 128391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004A48 File Offset: 0x00002C48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128397, RefRangeEnd = 128400, XrefRangeStart = 128396, XrefRangeEnd = 128397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssignableFrom(Type t, Type from)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004A9C File Offset: 0x00002C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128400, XrefRangeEnd = 128407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004B04 File Offset: 0x00002D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128407, XrefRangeEnd = 128414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004B6C File Offset: 0x00002D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128428, RefRangeEnd = 128429, XrefRangeStart = 128414, XrefRangeEnd = 128428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004BBC File Offset: 0x00002DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128448, RefRangeEnd = 128449, XrefRangeStart = 128429, XrefRangeEnd = 128448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004C2C File Offset: 0x00002E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128468, RefRangeEnd = 128469, XrefRangeStart = 128449, XrefRangeEnd = 128468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetFieldMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004C9C File Offset: 0x00002E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128469, XrefRangeEnd = 128474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetFieldClass(IntPtr field)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref field;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetFieldClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004CDC File Offset: 0x00002EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128474, XrefRangeEnd = 128485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFieldSignature(IntPtr field)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref field;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetFieldSignature_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004D14 File Offset: 0x00002F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128485, XrefRangeEnd = 128494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delegateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interfaze;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004D60 File Offset: 0x00002F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128505, RefRangeEnd = 128507, XrefRangeStart = 128494, XrefRangeEnd = 128505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proxy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_SetNativeExceptionOnProxy_Public_Static_Void_IntPtr_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000022BD File Offset: 0x000004BD
		public AndroidReflection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022C6 File Offset: 0x000004C6
		public unsafe static GlobalJavaObjectRef s_ReflectionHelperClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004DDC File Offset: 0x00002FDC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000022D8 File Offset: 0x000004D8
		public unsafe static IntPtr s_ReflectionHelperGetConstructorID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004DF8 File Offset: 0x00002FF8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000022E6 File Offset: 0x000004E6
		public unsafe static IntPtr s_ReflectionHelperGetMethodID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004E14 File Offset: 0x00003014
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000022F4 File Offset: 0x000004F4
		public unsafe static IntPtr s_ReflectionHelperGetFieldID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004E30 File Offset: 0x00003030
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002302 File Offset: 0x00000502
		public unsafe static IntPtr s_ReflectionHelperGetFieldSignature
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004E4C File Offset: 0x0000304C
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002310 File Offset: 0x00000510
		public unsafe static IntPtr s_ReflectionHelperNewProxyInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004E68 File Offset: 0x00003068
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000231E File Offset: 0x0000051E
		public unsafe static IntPtr s_ReflectionHelperSetNativeExceptionOnProxy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperSetNativeExceptionOnProxy, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperSetNativeExceptionOnProxy, (void*)(&value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004E84 File Offset: 0x00003084
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000232C File Offset: 0x0000052C
		public unsafe static IntPtr s_FieldGetDeclaringClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperClass;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetMethodID;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldID;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperSetNativeExceptionOnProxy;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_s_FieldGetDeclaringClass;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldSignature_Public_Static_String_IntPtr_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeExceptionOnProxy_Public_Static_Void_IntPtr_Exception_Boolean_0;

		// Token: 0x04000045 RID: 69
		public const string RELECTION_HELPER_CLASS_NAME = "com/unity3d/player/ReflectionHelper";
	}
}
