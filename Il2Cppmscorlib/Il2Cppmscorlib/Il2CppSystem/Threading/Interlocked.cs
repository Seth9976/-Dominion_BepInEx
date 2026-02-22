using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028C RID: 652
	public static class Interlocked : Object
	{
		// Token: 0x06002C4B RID: 11339 RVA: 0x000E1EAC File Offset: 0x000E00AC
		// Note: this type is marked as 'beforefieldinit'.
		static Interlocked()
		{
			Il2CppClassPointerStore<Interlocked>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Interlocked");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interlocked>.NativeClassPtr);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670330);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670331);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670332);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670333);
			Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670334);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670335);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670336);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670337);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670338);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670339);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670340);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670341);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670342);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670343);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670344);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670345);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670346);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670347);
			Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670348);
			Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100670349);
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000E206C File Offset: 0x000E026C
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 333578, RefRangeEnd = 333623, XrefRangeStart = 333577, XrefRangeEnd = 333578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000E20C8 File Offset: 0x000E02C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 333624, RefRangeEnd = 333630, XrefRangeStart = 333623, XrefRangeEnd = 333624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &succeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000E2130 File Offset: 0x000E0330
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 333631, RefRangeEnd = 333646, XrefRangeStart = 333630, XrefRangeEnd = 333631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CompareExchange(ref Object location1, Object value, Object comparand)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000E21B0 File Offset: 0x000E03B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333647, RefRangeEnd = 333648, XrefRangeStart = 333646, XrefRangeEnd = 333647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CompareExchange(ref float location1, float value, float comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x000E220C File Offset: 0x000E040C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 333649, RefRangeEnd = 333654, XrefRangeStart = 333648, XrefRangeEnd = 333649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Decrement(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x000E224C File Offset: 0x000E044C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 333655, RefRangeEnd = 333670, XrefRangeStart = 333654, XrefRangeEnd = 333655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Increment(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000E228C File Offset: 0x000E048C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333671, RefRangeEnd = 333674, XrefRangeStart = 333670, XrefRangeEnd = 333671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Increment(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000E22CC File Offset: 0x000E04CC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 333675, RefRangeEnd = 333698, XrefRangeStart = 333674, XrefRangeEnd = 333675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Exchange(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000E2318 File Offset: 0x000E0518
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 333699, RefRangeEnd = 333708, XrefRangeStart = 333698, XrefRangeEnd = 333699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Exchange(ref Object location1, Object value)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000E2388 File Offset: 0x000E0588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333708, XrefRangeEnd = 333709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exchange(ref float location1, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000E23D4 File Offset: 0x000E05D4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 333631, RefRangeEnd = 333646, XrefRangeStart = 333631, XrefRangeEnd = 333646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CompareExchange(ref long location1, long value, long comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000E2430 File Offset: 0x000E0630
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 333631, RefRangeEnd = 333646, XrefRangeStart = 333631, XrefRangeEnd = 333646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000E248C File Offset: 0x000E068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333709, XrefRangeEnd = 333710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CompareExchange(ref double location1, double value, double comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000E24E8 File Offset: 0x000E06E8
		[CallerCount(0)]
		public unsafe static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T).IsValueType)
			{
				T t2 = comparand;
				intPtr3 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref comparand;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			location1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr4, false, true);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000E25D0 File Offset: 0x000E07D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 333699, RefRangeEnd = 333708, XrefRangeStart = 333699, XrefRangeEnd = 333708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Exchange(ref long location1, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000E261C File Offset: 0x000E081C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 333699, RefRangeEnd = 333708, XrefRangeStart = 333699, XrefRangeEnd = 333708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Exchange(ref IntPtr location1, IntPtr value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000E2668 File Offset: 0x000E0868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333710, XrefRangeEnd = 333711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Exchange(ref double location1, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000E26B4 File Offset: 0x000E08B4
		[CallerCount(0)]
		public unsafe static T Exchange<T>(ref T location1, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			location1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000E2754 File Offset: 0x000E0954
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 333712, RefRangeEnd = 333726, XrefRangeStart = 333711, XrefRangeEnd = 333712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Read(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000E2794 File Offset: 0x000E0994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333727, RefRangeEnd = 333728, XrefRangeStart = 333726, XrefRangeEnd = 333727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Add(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0000F6BE File Offset: 0x0000D8BE
		public Interlocked(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04002684 RID: 9860
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0;

		// Token: 0x04002685 RID: 9861
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x04002686 RID: 9862
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0;

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x020005F4 RID: 1524
		private sealed class MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>
		{
			// Token: 0x040042F6 RID: 17142
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005F5 RID: 1525
		private sealed class MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>
		{
			// Token: 0x040042F7 RID: 17143
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
