using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200018B RID: 395
	public static class CustomAttributeExtensions : Object
	{
		// Token: 0x06001B57 RID: 6999 RVA: 0x0009D654 File Offset: 0x0009B854
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeExtensions()
		{
			Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100667894);
			CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr, 100667895);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0009D6AC File Offset: 0x0009B8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316805, RefRangeEnd = 316806, XrefRangeStart = 316804, XrefRangeEnd = 316805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0009D704 File Offset: 0x0009B904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316812, RefRangeEnd = 316814, XrefRangeStart = 316806, XrefRangeEnd = 316812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeExtensions.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000096B5 File Offset: 0x000078B5
		public CustomAttributeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0;

		// Token: 0x020005C2 RID: 1474
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_T_Assembly_0<T>
		{
			// Token: 0x040041BF RID: 16831
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomAttributeExtensions.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_T_Assembly_0, Il2CppClassPointerStore<CustomAttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
