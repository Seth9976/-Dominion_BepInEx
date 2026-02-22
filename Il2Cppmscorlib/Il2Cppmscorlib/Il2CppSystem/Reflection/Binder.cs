using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019C RID: 412
	[Serializable]
	public class Binder : Object
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x0009E228 File Offset: 0x0009C428
		// Note: this type is marked as 'beforefieldinit'.
		static Binder()
		{
			Il2CppClassPointerStore<Binder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Binder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Binder>.NativeClassPtr);
			Binder.NativeMethodInfoPtr_BindToMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667911);
			Binder.NativeMethodInfoPtr_BindToField_Public_Abstract_Virtual_New_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667912);
			Binder.NativeMethodInfoPtr_SelectMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667913);
			Binder.NativeMethodInfoPtr_SelectProperty_Public_Abstract_Virtual_New_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667914);
			Binder.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667915);
			Binder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667916);
			Binder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Binder>.NativeClassPtr, 100667917);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0009E2E4 File Offset: 0x0009C4E4
		[CallerCount(0)]
		public unsafe virtual MethodBase BindToMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, ref Il2CppReferenceArray<Object> args, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray names, out Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_BindToMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			args = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			state = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr7) : null;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0009E3D4 File Offset: 0x0009C5D4
		[CallerCount(0)]
		public unsafe virtual FieldInfo BindToField(BindingFlags bindingAttr, Il2CppReferenceArray<FieldInfo> match, Object value, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_BindToField_Public_Abstract_Virtual_New_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0009E464 File Offset: 0x0009C664
		[CallerCount(0)]
		public unsafe virtual MethodBase SelectMethod(BindingFlags bindingAttr, Il2CppReferenceArray<MethodBase> match, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_SelectMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
		[CallerCount(0)]
		public unsafe virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, Il2CppReferenceArray<PropertyInfo> match, Type returnType, Il2CppReferenceArray<Type> indexes, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_SelectProperty_Public_Abstract_Virtual_New_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0009E598 File Offset: 0x0009C798
		[CallerCount(0)]
		public unsafe virtual Object ChangeType(Object value, Type type, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0009E618 File Offset: 0x0009C818
		[CallerCount(0)]
		public unsafe virtual void ReorderArgumentArray(ref Il2CppReferenceArray<Object> args, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Binder.NativeMethodInfoPtr_ReorderArgumentArray_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0009E68C File Offset: 0x0009C88C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Binder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Binder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Binder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000098A3 File Offset: 0x00007AA3
		public Binder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeMethodInfoPtr_BindToMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_byref_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_byref_Object_0;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeMethodInfoPtr_BindToField_Public_Abstract_Virtual_New_FieldInfo_BindingFlags_Il2CppReferenceArray_1_FieldInfo_Object_CultureInfo_0;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeMethodInfoPtr_SelectMethod_Public_Abstract_Virtual_New_MethodBase_BindingFlags_Il2CppReferenceArray_1_MethodBase_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Public_Abstract_Virtual_New_PropertyInfo_BindingFlags_Il2CppReferenceArray_1_PropertyInfo_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Abstract_Virtual_New_Object_Object_Type_CultureInfo_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr_ReorderArgumentArray_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_Object_Object_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
