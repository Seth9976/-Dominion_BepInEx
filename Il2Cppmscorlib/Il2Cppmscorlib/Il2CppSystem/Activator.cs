using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000072 RID: 114
	public sealed class Activator : Object
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0004137C File Offset: 0x0003F57C
		// Note: this type is marked as 'beforefieldinit'.
		static Activator()
		{
			Il2CppClassPointerStore<Activator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Activator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Activator>.NativeClassPtr);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664377);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664378);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664379);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664380);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664381);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664382);
			Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activator>.NativeClassPtr, 100664383);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00041438 File Offset: 0x0003F638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275481, RefRangeEnd = 275482, XrefRangeStart = 275480, XrefRangeEnd = 275481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000414C4 File Offset: 0x0003F6C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275489, RefRangeEnd = 275492, XrefRangeStart = 275482, XrefRangeEnd = 275489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00041560 File Offset: 0x0003F760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275493, RefRangeEnd = 275496, XrefRangeStart = 275492, XrefRangeEnd = 275493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000415C4 File Offset: 0x0003F7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275497, RefRangeEnd = 275498, XrefRangeStart = 275496, XrefRangeEnd = 275497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, Il2CppReferenceArray<Object> args, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0004162C File Offset: 0x0003F82C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 275499, RefRangeEnd = 275507, XrefRangeStart = 275498, XrefRangeEnd = 275499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00041670 File Offset: 0x0003F870
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 275514, RefRangeEnd = 275520, XrefRangeStart = 275507, XrefRangeEnd = 275514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, bool nonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000416C4 File Offset: 0x0003F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275520, XrefRangeEnd = 275531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activator.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0000446B File Offset: 0x0000266B
		public static Object CreateInstance(Type type, params Object[] args)
		{
			return Activator.CreateInstance(type, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00004479 File Offset: 0x00002679
		public Activator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Boolean_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x0200058B RID: 1419
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x04003F97 RID: 16279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Activator.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<Activator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
