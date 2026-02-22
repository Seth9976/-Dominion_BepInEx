using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200004F RID: 79
	public static class ThrowHelper : Object
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x00035720 File Offset: 0x00033920
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664000);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664001);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664002);
			ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664003);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664004);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664005);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664006);
			ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664007);
			ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664008);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664009);
			ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100664010);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0003582C File Offset: 0x00033A2C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 266002, RefRangeEnd = 266012, XrefRangeStart = 265999, XrefRangeEnd = 266002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00035860 File Offset: 0x00033A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266020, RefRangeEnd = 266021, XrefRangeStart = 266012, XrefRangeEnd = 266020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000358A0 File Offset: 0x00033AA0
		[CallerCount(338)]
		[CachedScanResults(RefRangeStart = 266022, RefRangeEnd = 266360, XrefRangeStart = 266021, XrefRangeEnd = 266022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000358C8 File Offset: 0x00033AC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 266376, RefRangeEnd = 266382, XrefRangeStart = 266360, XrefRangeEnd = 266376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowWrongValueTypeArgumentException(Object value, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00035910 File Offset: 0x00033B10
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 266389, RefRangeEnd = 266416, XrefRangeStart = 266382, XrefRangeEnd = 266389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00035944 File Offset: 0x00033B44
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 266434, RefRangeEnd = 266460, XrefRangeStart = 266416, XrefRangeEnd = 266434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00035984 File Offset: 0x00033B84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 266467, RefRangeEnd = 266470, XrefRangeStart = 266460, XrefRangeEnd = 266467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000359B8 File Offset: 0x00033BB8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 266477, RefRangeEnd = 266498, XrefRangeStart = 266470, XrefRangeEnd = 266477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000359EC File Offset: 0x00033BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266498, XrefRangeEnd = 266499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IfNullAndNullsAreIllegalThenThrow<T>(Object value, ExceptionArgument argName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00035A30 File Offset: 0x00033C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266525, RefRangeEnd = 266527, XrefRangeStart = 266499, XrefRangeEnd = 266525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArgumentName(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00035A68 File Offset: 0x00033C68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 266575, RefRangeEnd = 266579, XrefRangeStart = 266527, XrefRangeEnd = 266575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceName(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003E02 File Offset: 0x00002002
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0;

		// Token: 0x0200054C RID: 1356
		private sealed class MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>
		{
			// Token: 0x04003F2C RID: 16172
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0, Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
