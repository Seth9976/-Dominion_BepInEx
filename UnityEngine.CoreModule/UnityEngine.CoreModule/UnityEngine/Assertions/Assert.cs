using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	// Token: 0x02000172 RID: 370
	public static class Assert : Object
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x00060A6C File Offset: 0x0005EC6C
		// Note: this type is marked as 'beforefieldinit'.
		static Assert()
		{
			Il2CppClassPointerStore<Assert>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "Assert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assert>.NativeClassPtr);
			Assert.NativeFieldInfoPtr_raiseExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assert>.NativeClassPtr, "raiseExceptions");
			Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100665295);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100665296);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100665297);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00060AEC File Offset: 0x0005ECEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83215, XrefRangeEnd = 83239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fail(string message, string userMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00060B34 File Offset: 0x0005ED34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83243, RefRangeEnd = 83244, XrefRangeStart = 83239, XrefRangeEnd = 83243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00060B68 File Offset: 0x0005ED68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83278, RefRangeEnd = 83279, XrefRangeStart = 83244, XrefRangeEnd = 83278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0000F048 File Offset: 0x0000D248
		public Assert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00060BAC File Offset: 0x0005EDAC
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0000F051 File Offset: 0x0000D251
		public unsafe static bool raiseExceptions
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&value));
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0000F05F File Offset: 0x0000D25F
		public new static bool Equals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.Equals should not be used for Assertions");
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0000F06C File Offset: 0x0000D26C
		public static bool ReferenceEquals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00060BC8 File Offset: 0x0005EDC8
		public static void IsFalse(bool condition)
		{
			if (condition)
			{
				Assert.IsFalse(condition, null);
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00060BE4 File Offset: 0x0005EDE4
		public static void IsFalse(bool condition, string message)
		{
			if (condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(false), message);
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0000F079 File Offset: 0x0000D279
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000F086 File Offset: 0x0000D286
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000F093 File Offset: 0x0000D293
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0000F0B2 File Offset: 0x0000D2B2
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0000F0BF File Offset: 0x0000D2BF
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0000F0D9 File Offset: 0x0000D2D9
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0000F0EB File Offset: 0x0000D2EB
		public static void AreEqual<T>(T expected, T actual)
		{
			Assert.AreEqual<T>(expected, actual, null);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0000F0F7 File Offset: 0x0000D2F7
		public static void AreEqual<T>(T expected, T actual, string message)
		{
			Assert.AreEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00060C04 File Offset: 0x0005EE04
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = !comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
				}
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00060C78 File Offset: 0x0005EE78
		public static void AreEqual(Object expected, Object actual, string message)
		{
			bool flag = actual != expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000F108 File Offset: 0x0000D308
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0000F114 File Offset: 0x0000D314
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00060CA0 File Offset: 0x0005EEA0
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreNotEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
				}
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00060D10 File Offset: 0x0005EF10
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
			bool flag = actual == expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0000F125 File Offset: 0x0000D325
		public static void IsNull<T>(T value) where T : class
		{
			Assert.IsNull<T>(value, null);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00060D38 File Offset: 0x0005EF38
		public static void IsNull<T>(T value, string message) where T : class
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.IsNull(value.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = value != null;
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
				}
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00060D9C File Offset: 0x0005EF9C
		public static void IsNull(Object value, string message)
		{
			bool flag = value != null;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0000F130 File Offset: 0x0000D330
		public static void IsNotNull<T>(T value) where T : class
		{
			Assert.IsNotNull<T>(value, null);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00060DC4 File Offset: 0x0005EFC4
		public static void IsNotNull<T>(T value, string message) where T : class
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.IsNotNull(value.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = value == null;
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
				}
			}
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00060E28 File Offset: 0x0005F028
		public static void IsNotNull(Object value, string message)
		{
			bool flag = value == null;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00060E50 File Offset: 0x0005F050
		public static void AreEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00060E74 File Offset: 0x0005F074
		public static void AreEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00060E98 File Offset: 0x0005F098
		public static void AreNotEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00060EB8 File Offset: 0x0005F0B8
		public static void AreNotEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		public static void AreEqual(byte expected, byte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00060EFC File Offset: 0x0005F0FC
		public static void AreEqual(byte expected, byte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00060F20 File Offset: 0x0005F120
		public static void AreNotEqual(byte expected, byte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00060F40 File Offset: 0x0005F140
		public static void AreNotEqual(byte expected, byte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00060F60 File Offset: 0x0005F160
		public static void AreEqual(char expected, char actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00060F84 File Offset: 0x0005F184
		public static void AreEqual(char expected, char actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		public static void AreNotEqual(char expected, char actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00060FC8 File Offset: 0x0005F1C8
		public static void AreNotEqual(char expected, char actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00060FE8 File Offset: 0x0005F1E8
		public static void AreEqual(short expected, short actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0006100C File Offset: 0x0005F20C
		public static void AreEqual(short expected, short actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00061030 File Offset: 0x0005F230
		public static void AreNotEqual(short expected, short actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00061050 File Offset: 0x0005F250
		public static void AreNotEqual(short expected, short actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00061070 File Offset: 0x0005F270
		public static void AreEqual(ushort expected, ushort actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00061094 File Offset: 0x0005F294
		public static void AreEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000610B8 File Offset: 0x0005F2B8
		public static void AreNotEqual(ushort expected, ushort actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000610D8 File Offset: 0x0005F2D8
		public static void AreNotEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000610F8 File Offset: 0x0005F2F8
		public static void AreEqual(int expected, int actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0006111C File Offset: 0x0005F31C
		public static void AreEqual(int expected, int actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00061140 File Offset: 0x0005F340
		public static void AreNotEqual(int expected, int actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00061160 File Offset: 0x0005F360
		public static void AreNotEqual(int expected, int actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00061180 File Offset: 0x0005F380
		public static void AreEqual(uint expected, uint actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000611A4 File Offset: 0x0005F3A4
		public static void AreEqual(uint expected, uint actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000611C8 File Offset: 0x0005F3C8
		public static void AreNotEqual(uint expected, uint actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000611E8 File Offset: 0x0005F3E8
		public static void AreNotEqual(uint expected, uint actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00061208 File Offset: 0x0005F408
		public static void AreEqual(long expected, long actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0006122C File Offset: 0x0005F42C
		public static void AreEqual(long expected, long actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00061250 File Offset: 0x0005F450
		public static void AreNotEqual(long expected, long actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00061270 File Offset: 0x0005F470
		public static void AreNotEqual(long expected, long actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00061290 File Offset: 0x0005F490
		public static void AreEqual(ulong expected, ulong actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000612B4 File Offset: 0x0005F4B4
		public static void AreEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000612D8 File Offset: 0x0005F4D8
		public static void AreNotEqual(ulong expected, ulong actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000612F8 File Offset: 0x0005F4F8
		public static void AreNotEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr_raiseExceptions;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0;

		// Token: 0x04001528 RID: 5416
		public const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";
	}
}
